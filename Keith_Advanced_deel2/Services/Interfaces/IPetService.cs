using Keith_Advanced_deel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.Services.Interfaces
{
    public interface IPetService
    {
        public Pet CreatePet(Pet pet);
    }
}
