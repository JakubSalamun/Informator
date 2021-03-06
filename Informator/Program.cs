using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;

namespace Informator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Witaj podaj swoje dane!");
            Console.Write("Miasto:");
            var userInputAdressCity = Console.ReadLine();

            Console.Write("(Nazwa i numer/numer)Ulica:");
            var userInputAdressStret = Console.ReadLine();

            Console.Write("Kod Ppocztowy:");
            var userInputAdressPostalCode = Console.ReadLine();

            Console.Write("Imie:");
            var userInputName = Console.ReadLine();

            Console.Write("Nazwisko:");
            var userInputLastName = Console.ReadLine();

            Console.Write("(1-Male/2-Female)Płeć:");
            var userInputGender = Console.ReadLine();

            string csvPath = @"C:\Users\Komputer\Downloads\lost.csv";
            var lostPeople = LoadFile(csvPath);

            PersonHelp(userInputName, userInputLastName, userInputGender, new Adress(userInputAdressCity, userInputAdressStret, userInputAdressPostalCode));

            GetData(lostPeople, userInputName, userInputLastName);

            
        }

        static void GetData(IEnumerable<Person> people,string name,string lastname)
        {
            var lostPeople = people.FirstOrDefault(p => p.FirstName == name && p.LastName == lastname);
            if (lostPeople!=null)
            {
                Console.WriteLine("Znaloeziono osobę");
            }
            else
            {
                Console.WriteLine("Brak danych");
            }
        }

        public static string PersonCheckGender(string gender)
        {
            Gender userGender = (Gender)Enum.Parse(typeof(Gender), gender);
            if (userGender == Gender.Male)
            {
                var helpGender = "Mr.";
                return helpGender;
        
            }
            else
            {
                var helpGender = "Miss.";
                return helpGender;
            }
      
        }

        public static void PersonHelp(string firstName, string lastName, string gender, Adress adress)
        {
            var helpGender = PersonCheckGender(gender);
            List<Person> personList = new List<Person>();
            personList.Add(new Person { FirstName = firstName, LastName = lastName, adress = adress });
            foreach (var item in personList)
            {
                Console.WriteLine($"Prson:{helpGender}{item.FirstName} {item.LastName}\nAdres:{item.adress.City} {item.adress.Streat} {item.adress.PostalCode}");
            }
      
        }
  
 

        static List<Person> LoadFile(string csvPath)
        {
            using (var reader=new StreamReader(csvPath))
            using (var csv=new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<PersonMap>();
                var records = csv.GetRecords<Person>().ToList();
                return records;
            }
        }

    }
}
