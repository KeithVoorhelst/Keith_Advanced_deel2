using Keith_Advanced_deel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.Services.Interfaces
{
    public interface IHouseService
    {
        public House CreateHouse(House house);
        public House GetHouseById(int houseId);
        public House UpdateHouseById(int houseId, House houseEditValues);
        public List<House> GetAllHouses();
        public House DeleteHouseById(int houseId);

    }
}
