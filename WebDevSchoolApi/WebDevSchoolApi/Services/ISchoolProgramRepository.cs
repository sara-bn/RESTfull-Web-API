using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDevSchoolApi.Entities;

namespace WebDevSchoolApi.Services
{
    public interface ISchoolProgramRepository
    {
        //methods for manupilating school data
        IEnumerable<School> GetSchools();
        School GetSchoolById(Guid schoolId);
        void AddSchool(School school);
        void UpdateSchool(School school);
        void DeleteSchool(School school);

        //methods for manupilating program data
        IEnumerable<DevProgram> GetPrograms(Guid schoolId);
        DevProgram GetProgramById(Guid schoolId, Guid programId);
        void AddProgram(Guid schoolId, DevProgram program);
        void UpdateProgram(DevProgram program);
        void DeleteProgram(DevProgram program);
        bool SchoolExists(Guid schoolId);
        bool Save();
    }
}
