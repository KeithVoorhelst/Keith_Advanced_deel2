using AutoMapper;
using Keith_Advanced_deel2.Db;
using Keith_Advanced_deel2.DTO;
using Keith_Advanced_deel2.DTO.PetDTO;
using Keith_Advanced_deel2.Models;
using Keith_Advanced_deel2.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetService _petService;
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PetController(IPetService petService, IPersonService personService, IMapper mapper)
        {
            _petService = petService;
            _personService = personService;
            _mapper = mapper;
        }
        [HttpPost("AddPet")]
        public ActionResult<Pet> AddPet(CreatePetDTO createPetDTO, int personId)
        {
            var newPet = _mapper.Map<Pet>(createPetDTO);
            Pet petToAddToDb = _petService.CreatePet(newPet, personId);
            return Ok(petToAddToDb);
        }
        [HttpGet ("AllPets")]
        public ActionResult<List<Pet>> GetAllPets()
        {
            return Ok(_petService.GetAllPets());
        }
        [HttpGet("PetById")]
        public ActionResult<Pet> GetPetById(int petId)
        {
            var pet = _petService.GetPetById(petId);
            if (pet == null)
            {
                return NotFound();
            }
            return Ok(pet);
        }
        [HttpPut("UpdatePetById")]
        public ActionResult<Pet> UpdatePetById(int petId, Pet petEditValues)
        {
            var pet = _petService.UpdatePetById(petId, petEditValues);
            return Ok(pet);
        }
        [HttpPut("ChangeOwner")]
        public ActionResult<Pet> ChangeOwner(int petId, int newOwnerId)
        {
            var pet = _petService.ChangeOwner(petId, newOwnerId);
            return Ok(pet);
        }
        [HttpDelete ("DeletePetById")]
        public ActionResult<Pet> DeletePetById(int petId)
        {
            var pet = _petService.DeletePetById(petId);
            return Ok(pet);
        }
        
    }
}
