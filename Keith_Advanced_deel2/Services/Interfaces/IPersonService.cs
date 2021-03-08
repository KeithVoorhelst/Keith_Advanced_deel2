using Keith_Advanced_deel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Keith_Advanced_deel2.Services.Interfaces
{
    public interface IPersonService
    {
        public Person CreatePerson(Person person);
        public Person Login(string email, string password);
        public Person ChangePassword(string email, string password, string newPassword);
        public Person DeletePerson(int Id, string email, string password);
    }
}
