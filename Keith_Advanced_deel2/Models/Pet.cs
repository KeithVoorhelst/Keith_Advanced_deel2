using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace Keith_Advanced_deel2.Models
{
    public class Pet
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PetType Type { get; set; }
        public int? PersonId { get; set; }
        public Person Person { get; set; }
    }
}
