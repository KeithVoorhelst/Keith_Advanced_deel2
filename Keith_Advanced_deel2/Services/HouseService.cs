using Keith_Advanced_deel2.Db;
using Keith_Advanced_deel2.Models;
using Keith_Advanced_deel2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.Services
{
    public class HouseService : IHouseService
    {
        public House CreateHouse(House house)
        {
            using (var db = new PersonPetHouseContext())
            {
                db.Add(house);
                db.SaveChanges();
                return house;
            }
        }
        public List<House> GetAllHouses()
        {
            using (var db = new PersonPetHouseContext())
            {
                var listOfHouses = db.Houses.ToList();
                return listOfHouses;
            }
        }

        public House GetHouseById(int houseId)
        {
            using (var db = new PersonPetHouseContext())
            {
                var house = db.Houses.FirstOrDefault(x => x.Id == houseId);
                return house;
            }
        }

        public House UpdateHouseById(int houseId, House houseEditValues)
        {
            using (var db = new PersonPetHouseContext())
            {
                var houseToUpdate = db.Houses.FirstOrDefault(x => x.Id == houseId);
                houseToUpdate.Street = houseEditValues.Street;
                houseToUpdate.Number = houseEditValues.Number;
                houseToUpdate.PostalCode = houseEditValues.PostalCode;
                houseToUpdate.Community = houseEditValues.Community;
                db.Houses.Update(houseToUpdate);
                db.SaveChanges();
                return houseToUpdate;
            }
        }
        public House DeleteHouseById(int houseId)
        {
            using (var db = new PersonPetHouseContext())
            {
                var houseToDelete = db.Houses.FirstOrDefault(x => x.Id == houseId);
                db.Houses.Remove(houseToDelete);
                db.SaveChanges();
                return houseToDelete;
            }
        }
    }
}