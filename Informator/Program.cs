using System;

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
            Person person = new Person();
            person.FirstName = firstName;
            person.LastName = lastName;
            person.adress = adress;
            

            Console.WriteLine($"First name:{person.FirstName}, Last name:{person.LastName}, Lokalizacjia:  {adress.City} {adress.PostalCode} {adress.Streat}");
        }
    }
}
