using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserGroups.Models
{
    public class GroupViewModel
    {
        public GroupViewModel()
        {

        }

        public GroupViewModel(int id, string name, string description, int numMembers, string coverImageUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            NumMembers = numMembers;
            CoverImageUrl = coverImageUrl;
        }

        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int NumMembers { get; set; }
        public string CoverImageUrl { get; set; }
    }
}
