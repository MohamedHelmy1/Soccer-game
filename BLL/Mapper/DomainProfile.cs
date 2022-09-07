using AutoMapper;
using DAL.Entities;

using DAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<player, PlayerViewModel>().ReverseMap();
            CreateMap<Teem, TeemViewModel>().ReverseMap();
           


        }
    }
}
 