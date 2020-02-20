using System;
using System.Collections.Generic;
//Imported these 2 Libraries 
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//Above two Libraries
using System.Linq;
using System.Threading.Tasks;

namespace COMP2084MidtermW20.Models
{
    public class Party
    {
        public Party()
        {
            Election = new HashSet<Election>();
            Name = ""; //Initialized this one
            Logo = ""; //Initialized this one
        }

        public int PartyId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Logo { get; set; }

        [InverseProperty("Party")]
        public virtual ICollection<Election> Election { get; set; }
    }
}
