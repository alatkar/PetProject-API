using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetProject_API.DataAccess.Models;

namespace PetProject_API.DataAccess
{
    public class PetDataContext : DbContext
    {
        public PetDataContext(DbContextOptions<PetDataContext> options) : base(options)
        {
        }

        public DbSet<DogProfile> DogProfiles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
