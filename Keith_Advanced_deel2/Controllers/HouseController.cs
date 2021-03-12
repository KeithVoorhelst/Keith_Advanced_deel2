using AutoMapper;
using Keith_Advanced_deel2.DTO;
using Keith_Advanced_deel2.DTO.HouseDTO;
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
    public class HouseController : ControllerBase
    {
        private readonly IHouseService _houseService;
        private readonly IMapper _mapper;

        public HouseController(IHouseService houseService, IMapper mapper)
        {
            _houseService = houseService;
            _mapper = mapper;
        }

        [HttpPost("AddHouse")]
        public ActionResult<House> AddHouse(CreateHouseDTO createHouseDTO)
        {
            var newHouse = _mapper.Map<House>(createHouseDTO);
            _houseService.CreateHouse(newHouse);
            return Ok();
        }

        [HttpGet ("GetHouseById")]
        public ActionResult<House> GetHouseById(int houseId)
        {
            var house = _houseService.GetHouseById(houseId);
            if (house == null)
            {
                return NotFound();
            }
            return Ok(house);
        }
        [HttpGet("GetAllHouses")]
        public ActionResult<List<House>> GetAllHouses()
        {
            return Ok(_houseService.GetAllHouses());
        }
        [HttpGet("GetAllHousesByPostal")]
        public ActionResult<List<House>> GetAllHousesByPostal(string postalCode)
        {
            var houses = _houseService.GetAllHousesByPostal(postalCode);
            return Ok(houses);
        }
        [HttpPut("UpdateHouseById")]
        public ActionResult<House> UpdateHouseById(int houseId, UpdateHouseDTO updateHouseDTO)
        {
            var house = _mapper.Map<House>(updateHouseDTO);
            _houseService.UpdateHouseById(houseId, house);
            return Ok(house);
        }
        [HttpDelete("DeleteHouseById")]
        public ActionResult<House> DeleteHouseById(int houseId)
        {
            var house = _houseService.DeleteHouseById(houseId);
            return Ok(house);
        }

    }
}
