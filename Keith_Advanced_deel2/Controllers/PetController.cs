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
        private readonly IMapper _mapper;

        public PetController(IPetService petService, IMapper mapper)
        {
            _petService = petService;
            _mapper = mapper;
        }
        [HttpPost("AddPet")]
        public ActionResult<Pet> AddPet(CreatePetDTO createPetDTO)
        {
            var petFromDTO = _mapper.Map<Pet>(createPetDTO);
            _petService.CreatePet(petFromDTO);
            return Ok();
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
        public ActionResult<Pet> UpdatePetById(int petId, UpdatePetDTO updatePetDTO)
        {
            var pet = _mapper.Map<Pet>(updatePetDTO);
            _petService.UpdatePetById(petId, pet);
            return Ok(pet);
        }
        [HttpPut("ChangeOwner")]
        public ActionResult<Pet> ChangeOwner(int petId, ChangeOwnerDTO changeOwnerDTO)
        {
            var pet = _mapper.Map<Pet>(changeOwnerDTO);
                _petService.ChangeOwner(petId, changeOwnerDTO.PersonId);
            return Ok(pet);
        }
        [HttpDelete ("DeletePetById")]
        public ActionResult<Pet> DeletePetById(int petId)
        {
            {
                try
                {
                    _petService.DeletePetById(petId);
                }
                catch (UnauthorizedAccessException)
                {
                    return Unauthorized();
                }
                return Ok();
            }
        }
        
    }
}
