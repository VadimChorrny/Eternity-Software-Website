using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? LocationId { get; set; }
        public Location Location { get; set; }
    }
}
