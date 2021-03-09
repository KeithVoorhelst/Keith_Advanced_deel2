using Keith_Advanced_deel2.DTO.PetDTO;
using Keith_Advanced_deel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.Services.Interfaces
{
    public interface IPetService
    {
        public Pet CreatePet(Pet pet, int personId);
        public List<Pet> GetAllPets();
        public Pet GetPetById(int petId);
        public Pet UpdatePetById(int petId, Pet petEditValues);
        public Pet DeletePetById(int petId);
        public Pet ChangeOwner(int petId, int newOwner);
    }
}
