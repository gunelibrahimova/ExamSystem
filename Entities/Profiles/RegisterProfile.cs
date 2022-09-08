using AutoMapper;
using Entites.DTO;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Profiles
{
    public class RegisterProfile:Profile
    {
        public RegisterProfile()
        {
            CreateMap<RegisterUserDTO, User>();
        }
    }
}
