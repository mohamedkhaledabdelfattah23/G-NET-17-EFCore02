using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Data
{
    public class Attendee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Street { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public Badge Badge { get; set; }
        public List<Registration> Registrations { get; set; }

    }
}
