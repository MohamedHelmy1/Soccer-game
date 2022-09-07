using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class TeemViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime Foundationdate { get; set; }
        public string CoachName { get; set; }
        public string LogoPath{ get; set; }
        public string Logo { get; set; }
        //public IFormFile Logo { get; set; }


    }
}
