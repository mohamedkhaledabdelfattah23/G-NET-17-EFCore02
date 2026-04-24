using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Data
{
    public class OrganizerProfile
    {
        [Key, ForeignKey("Organizer")]
        public int OrganizerId { get; set; }
        public string? Biography { get; set; }
        public string? Website { get; set; }
        public string? Logo { get; set; }
        public Organizer Organizer { get; set; }

    }
}
