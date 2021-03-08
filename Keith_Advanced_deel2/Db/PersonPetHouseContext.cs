using Keith_Advanced_deel2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Keith_Advanced_deel2.Db
{
    public class PersonPetHouseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<House> Houses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=PersonPetHouse.db");
    }

}
