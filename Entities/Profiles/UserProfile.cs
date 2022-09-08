using AutoMapper;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profiles
{
    public class UserProfile :Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>();
        }
    }
}