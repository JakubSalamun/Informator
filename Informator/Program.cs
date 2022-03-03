using System;
using System.Collections.Generic;

namespace Informator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj podaj swoje dane!");
            Console.Write("Imie:");
            var userInputName = Console.ReadLine();
            Console.Write("Nazwisko:");
            var userInputLastName = Console.ReadLine();

            Console.Write("Miasto:");
            var userInputAdressCity= Console.ReadLine();

            Console.Write("Ulica:");
            var userInputAdressStret = Console.ReadLine();

            Console.Write("Kod Ppocztowy:");
            var userInputAdressPostalCode = Console.ReadLine();

            PersonHelp(userInputName, userInputLastName, new Adress(userInputAdressCity, userInputAdressStret, userInputAdressPostalCode));


        }


        static void PersonHelp(string firstName,string lastName,Adress adress)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person { FirstName = firstName, LastName = lastName, adress = adress });
            foreach (var item in personList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.adress.City} {item.adress.Streat} {item.adress.PostalCode}");
            }
      
        }


    }
}
