using AutoMapper;
using Keith_Advanced_deel2.DTO;
using Keith_Advanced_deel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<CreatePersonDTO, Person>().ReverseMap();
            CreateMap<LoginPersonDTO, Person>().ReverseMap();
        }
    }
}
