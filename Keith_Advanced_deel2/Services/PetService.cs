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
        public void CreatePet(Pet pet)
        {
            using (var db = new PersonPetHouseContext())
            {
                db.Pets.Add(pet);
                db.SaveChanges();
            }
        }
        public List<Pet> GetAllPets()
        {
            using (var db = new PersonPetHouseContext())
            {
                var listOfPets = db.Pets.ToList();
                return listOfPets;
            }
        }
        public Pet GetPetById(int petId)
        {
            using (var db = new PersonPetHouseContext())
            {
                var petToFind = db.Pets.FirstOrDefault(x => x.Id == petId);
                return petToFind;
            }
        }
        public Pet UpdatePetById(int petId, Pet petEditValues)
        {
            using (var db = new PersonPetHouseContext())
            {
                var petToUpdate = db.Pets.FirstOrDefault(x => x.Id == petId);
                petToUpdate.Name = petEditValues.Name;
                petToUpdate.Type = petEditValues.Type;
                petToUpdate.DateOfBirth = petEditValues.DateOfBirth;
                db.Pets.Update(petToUpdate);
                db.SaveChanges();
                return petToUpdate;
            }
        }
        public void DeletePetById(int petId)
        {
            using (var db = new PersonPetHouseContext())
            {
                var petToDelete = db.Pets.FirstOrDefault(x => x.Id == petId);
                if (petToDelete != null)
                {
                    db.Pets.Remove(petToDelete);
                    db.SaveChanges();
                }
                else
                {
                    throw new UnauthorizedAccessException("invalid pet id");
                }
                
            }
        }

        public Pet ChangeOwner(int petId, int newOwnerId)
        {
            using (var db = new PersonPetHouseContext())
            {
                var petToChange = db.Pets.FirstOrDefault(p => p.Id == petId);
                var newPetOwner = db.Persons.FirstOrDefault(p => p.Id == newOwnerId);
                petToChange.Person = newPetOwner;
                db.Pets.Update(petToChange);
                db.SaveChanges();
                return petToChange;
            }
        }
    }
}
