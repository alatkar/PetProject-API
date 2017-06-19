using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetProject_API.DataAccess.Models
{
    public class User
    {
        [Column("Name")]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string AddressStreet1 { get; set; }
        public string AddressStreet2 { get; set; }
        public string AddressHouseNumber { get; set; }
        public string Apartment { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
    }
}
