using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public string Community { get; set; }
        public List<Person> Persons { get; set; }
    }
}
