using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

            var asyncMain = new Program(); //CS0120
            asyncMain.PersonHelp(userInputName, userInputLastName, userInputGender, new Adress(userInputAdressCity, userInputAdressStret, userInputAdressPostalCode));
            
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

        public async void PersonHelp(string firstName, string lastName, string gender, Adress adress)
        {
           var helpGender= PersonCheckGender(gender);
            List<Person> personList = new List<Person>();
            personList.Add(new Person { FirstName = firstName, LastName = lastName, adress = adress });
            foreach (var item in personList)
            {
                Console.WriteLine($"Prson:{helpGender}{item.FirstName} {item.LastName}\nAdres:{item.adress.City} {item.adress.Streat} {item.adress.PostalCode}");
            }
            await LostPeople(firstName, lastName);
        }

        private async Task LostPeople(string name,string lastname)
        {
            List<Person> lostPeople = new List<Person>();
            lostPeople.Add(new Person { FirstName = "Jan", LastName = "Kowalski" });
            lostPeople.Add(new Person { FirstName = "Ela", LastName = "Nowak" });
            lostPeople.Add(new Person { FirstName = "Arnold", LastName = "Michalski" });
            lostPeople.Add(new Person { FirstName = "Katarzyna", LastName = "Rasz" });

            foreach (var item in lostPeople)
            {
                if (name==item.FirstName && lastname==item.LastName)
                {
                    Console.WriteLine("Znaleziono osobę");
                    break;
                }
                else
                {
                    Console.WriteLine("Brak powiązania");
                    break;
                }
            }
        }

    }
}
