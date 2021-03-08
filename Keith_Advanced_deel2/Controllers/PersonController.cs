using AutoMapper;
using Keith_Advanced_deel2.DTO;
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
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PersonController(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }
        [HttpPost ("AddPerson")]
        public ActionResult<Person> AddPerson(CreatePersonDTO createPersonDTO)
        {
            var newPerson = _mapper.Map<Person>(createPersonDTO);
            _personService.CreatePerson(newPerson);
            return Ok();
        }
        [HttpPost ("Login")]
        public ActionResult<bool> Login (LoginPersonDTO loginPersonDTO)
        {
            var PersonToLogin = _personService.Login(loginPersonDTO.Email, loginPersonDTO.Password);

            if (PersonToLogin == null)
            {
                return Ok(false);
            }
            return Ok(true);

            
        }
        [HttpPut ("ChangePassword")]
        public ActionResult ChangePassword(ChangePasswordDTO changePasswordDTO)
        {

            var PersonToChange = _personService.ChangePassword(changePasswordDTO.Email, changePasswordDTO.Password, changePasswordDTO.NewPassword);
            if (PersonToChange == null)
            {
                return new UnauthorizedResult();
            }
            return Ok();
        }
        [HttpDelete("DeletePerson")]
        public ActionResult DeletePerson(DeletePersonDTO deletePersonDTO)
        {
            var personToDelete = _personService.DeletePerson(deletePersonDTO.Id, deletePersonDTO.Email, deletePersonDTO.Password);
            if (personToDelete == null)
            {
                return new UnauthorizedResult();
            }
            return Ok();
        }
    }
    
}
