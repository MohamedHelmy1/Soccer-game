using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModel
{
    public class PlayerViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }

        public Guid FK_TeemId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ImagePath { get; set; } 
        public string Photo { get; set; }





    }
}
