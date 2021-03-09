using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.Models
{
    public class Pet
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PetType Type { get; set; }
        public Person Person { get; set; }

        //private string type;
        //public string Type
        //{
        //    get { return type; }
        //    set
        //    {
        //        if (value == "Hond" || value == "Kat" || value == "Cavia" || value == "Goudvis")
        //        {
        //            type = value;
        //        }
        //        else
        //        {
        //            type = "unauthorized ";
        //        }
        //    }
        //}

    }
    public enum PetType
    {
        Cat,
        Dog,
        GuineaPig,
        Goldfish,
    }
}
