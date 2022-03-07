using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informator
{
   public class PersonMap :ClassMap<Person>
    {
        public PersonMap() 
        {
            Map(m => m.FirstName).Name(nameof(Person.FirstName));
            Map(m => m.LastName).Name(nameof(Person.LastName));
            Map(m => m.Gender).Name(nameof(Person.Gender));
            Map(m => m.adress.City).Name(nameof(Person.adress.City));
            Map(m => m.adress.Streat).Name(nameof(Person.adress.Streat));
            Map(m => m.adress.PostalCode).Name(nameof(Person.adress.PostalCode));
        }
        // użycię listy 
        //private List<string> ConvertLisy(ConvertFromStringArgs args)
        //{
        //    var genreString = args.Row.GetField("ListaNameFromFileCsv");
        //    return genreString.Split(";").ToList();
        //}
    }
}
