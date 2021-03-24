using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserGroups.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public DateTime BirthDate { get; set; }
        public string AvatarImageLink { get; set; }
    }
}
