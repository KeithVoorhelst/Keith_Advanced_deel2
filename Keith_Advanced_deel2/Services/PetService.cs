using Keith_Advanced_deel2.Db;
using Keith_Advanced_deel2.Models;
using Keith_Advanced_deel2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.Services
{
    public class PetService : IPetService
    {
        public Pet CreatePet(Pet pet)
        {
            using (var db = new PersonPetHouseContext())
            {
                db.Add(pet);
                db.SaveChanges();
                return pet;

            }
        }
    }
}
