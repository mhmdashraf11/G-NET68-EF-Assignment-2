using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.Models
{
    internal class Badge
    {
        // unique per attendee
        public int Number { get; set; }
        public DateTime IssuedDate  { get; set; }
        public BadgeTier Tier { get; set; }
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }

    }
}
