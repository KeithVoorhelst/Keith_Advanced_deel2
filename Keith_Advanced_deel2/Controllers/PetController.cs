using AutoMapper;
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
        public ActionResult<Pet> AddPet(CreatePetDTO createPetDTO)
        {
            var newPet = _mapper.Map<Pet>(createPetDTO);
            Pet petToAddToDb = _petService.CreatePet(newPet);
            return Ok(petToAddToDb);

            
        }
    }
}
