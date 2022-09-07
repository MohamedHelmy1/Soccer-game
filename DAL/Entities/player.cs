using Soccer_game_Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class player: BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]

        public string Nationality { get; set; } 
        
       
        [Required]

        public DateTime DateOfBirth { get; set; }
        [Required]

        public string ImagePath { get; set; } = null!;

        public Guid FK_TeemId { get; set; }

        [ForeignKey("FK_TeemId")]
        public Teem Teem { get; set; }
    }

}
