using Keith_Advanced_deel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.Services.Interfaces
{
    public interface IPersonService
    {
        void ChangePassword(string email, string currentPassword, string newPassword);
        void CreatePerson(Person person);
        void DeletePerson(int id, string email, string currentPassword);
        List<Pet> GetMyPets(int personId);
        bool Login(string email, string password);
    }
}
