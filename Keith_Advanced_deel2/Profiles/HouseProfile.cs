using Keith_Advanced_deel2.DTO.HouseDTO;
using Keith_Advanced_deel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Keith_Advanced_deel2.Profiles
{
    public class HouseProfile : Profile
    {
        public HouseProfile()
        {
            CreateMap<CreateHouseDTO, House>().ReverseMap();
            CreateMap<UpdateHouseDTO, House>().ReverseMap();
        }
    }
}
