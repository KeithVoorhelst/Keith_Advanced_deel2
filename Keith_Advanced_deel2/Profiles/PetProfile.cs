using AutoMapper;
using Keith_Advanced_deel2.DTO.PetDTO;
using Keith_Advanced_deel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.Profiles
{
    public class PetProfile : Profile
    {

        public PetProfile()
        {
            CreateMap<CreatePetDTO, Pet>()
               .ReverseMap();
        }
        
    }
}
