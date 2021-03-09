using Keith_Advanced_deel2.Db;
using Keith_Advanced_deel2.Models;
using Keith_Advanced_deel2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.Services
{
    public class PersonService : IPersonService
    {
        public Person CreatePerson(Person person, int houseId)
        {
            using (var db = new PersonPetHouseContext())
            {
                var house = db.Houses.FirstOrDefault(x => x.Id == houseId);
                person.House = house;
                db.Add(person);
                db.SaveChanges();
                return person;

            }
        }
        public Person Login(string email, string password)
        {
            using (var db = new PersonPetHouseContext())
            {
                var personToLogin = db.Persons.FirstOrDefault(x => x.Email == email && x.Password == password);

                return personToLogin;
            }
        }
        public Person ChangePassword(string email, string password, string newPassword)
        {
            using (var db = new PersonPetHouseContext())
            {
                var personToChangePW = Login(email, password);
                if (personToChangePW == null)
                {
                    return null;
                }
                personToChangePW.Password = newPassword;
                db.Update(personToChangePW);
                db.SaveChanges();
                return personToChangePW;
            }
        }
        public Person DeletePerson(int Id, string email, string password)
        {
            using (var db = new PersonPetHouseContext())
            {
                var personToDelete = Login(email, password);
                if (personToDelete != null)
                {
                    db.Persons.Remove(personToDelete);
                    db.SaveChanges();
                }
                return personToDelete;
            }
        }

        public List<Pet> GetMyPets(int personId)
        {
            using (var db = new PersonPetHouseContext())
            {
                var person = db.Persons.FirstOrDefault(x => x.Id == personId);
                var myPets = person.Pets.ToList();
                return myPets;
            }
        }
    }
}
