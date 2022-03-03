using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informator
{
   public class Adress
    {
        public Adress(string city, string streat,string postalCode)
        {
            City = city;
            Streat = streat;
            PostalCode = postalCode;
        }

        public string City { get; set; }
        public string Streat { get; set; }
        public string PostalCode { get; set; }
    }
}
