using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.Models
{
    internal class OrganizerProfile
    {
        public int Id { get; set; }
        public string? Bio{ get; set; }
        public string? WebsiteLink { get; set; }
        public string? Logo { get; set; }
        public int OrganizerId { get; set; }
        [InverseProperty(nameof(Organizer.Profile))]
        public Organizer Organizer { get; set; }


    }
}
