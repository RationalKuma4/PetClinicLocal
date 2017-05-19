using System.Collections.Generic;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PetClinicLocal.Models
{
    public class OwnerUser
    {
        [PrimaryKey, AutoIncrement]
        public int OwnerUserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [OneToMany]
        public IEnumerable<Pet> Pets { get; set; }
    }
}
