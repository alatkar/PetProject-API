using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetProject_API.DataAccess.Models
{
    public class DogProfile : BaseProfile
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime Dob { get; set; }
    }
}
