using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public  class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string MapLocation { get; set; }
        public bool Status { get; set; }
    }
}
