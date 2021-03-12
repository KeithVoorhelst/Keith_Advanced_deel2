using Keith_Advanced_deel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.DTO.PetDTO
{
    public class UpdatePetDTO
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PetType Type { get; set; }
    }
}
