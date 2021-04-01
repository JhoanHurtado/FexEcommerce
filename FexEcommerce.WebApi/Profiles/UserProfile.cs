using AutoMapper;
using FexEcommerce.Dtos;
using FexEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FexEcommerce.WebApi.Profiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            this.CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
