using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.Models
{
    internal class Attendee
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string FullName { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        public Address Address { get; set; } = new Address();
        [NotMapped]
        public string FullAddress => $"{Address.Street}, {Address.City}, {Address.Country}, {Address.PostalCode}";

        public Badge Badge { get; set; }

    }
}
