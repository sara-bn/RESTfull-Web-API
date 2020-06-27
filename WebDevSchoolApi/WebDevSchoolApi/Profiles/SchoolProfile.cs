using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevSchoolApi.Profiles
{
    public class SchoolProfile: Profile
    {
        public SchoolProfile()
        {
            CreateMap<Models.SchoolForCreation, Entities.School>();
        }
    }
}
