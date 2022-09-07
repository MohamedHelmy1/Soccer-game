using Soccer_game_Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Teem:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public DateTime Foundationdate { get; set; }
        [Required]
        public string CoachName { get; set; }
        
        public string LogoPath { get; set; }

    }
}
