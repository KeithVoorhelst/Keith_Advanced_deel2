using Keith_Advanced_deel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.DTO.HouseDTO
{
    public class CreateHouseDTO
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public string Community { get; set; }
    }
}
