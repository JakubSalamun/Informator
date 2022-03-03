using System;
using System.Collections.Generic;

namespace Informator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Witaj podaj swoje dane!");

            Console.Write("Miasto:");
            var userInputAdressCity = Console.ReadLine();

            Console.Write("Ulica:");
            var userInputAdressStret = Console.ReadLine();

            Console.Write("Kod Ppocztowy:");
            var userInputAdressPostalCode = Console.ReadLine();


            Console.Write("Imie:");
            var userInputName = Console.ReadLine();
            Console.Write("Nazwisko:");
            var userInputLastName = Console.ReadLine();
            Console.Write("(1-Male/2-Female)Płeć:");
            var userInputGender = Console.ReadLine();

            PersonHelp(userInputName, userInputLastName, userInputGender, new Adress(userInputAdressCity, userInputAdressStret, userInputAdressPostalCode));

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

       static void PersonHelp(string firstName, string lastName, string gender, Adress adress)
        {
           var helpGender= PersonCheckGender(gender);
            List<Person> personList = new List<Person>();
            personList.Add(new Person { FirstName = firstName, LastName = lastName, adress = adress });
            foreach (var item in personList)
            {
                Console.WriteLine($"{helpGender}{item.FirstName} {item.LastName} {item.adress.City} {item.adress.Streat} {item.adress.PostalCode}");
            }
        }



    }
}
