using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDevSchoolApi.DbContexts;
using WebDevSchoolApi.Entities;

namespace WebDevSchoolApi.Services
{
    public class SchoolProgramRepository : ISchoolProgramRepository
    {
        private readonly SchoolProgramContext _context;

        public SchoolProgramRepository(SchoolProgramContext context)
        {
            _context = context;
        }

        public void AddProgram(Guid schoolId, DevProgram program)
        {
            if (schoolId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(schoolId));
            }

            if (program == null)
            {
                throw new ArgumentNullException(nameof(program));
            }
            // always set the SchoolId to the passed-in schoolId
            program.SchoolId = schoolId;

            _context.DevPrograms.Add(program);
        }

        public void AddSchool(School school)
        {
            if (school == null)
            {
                throw new ArgumentNullException(nameof(school));
            }

            // the repository fills the id (instead of using identity columns)
            school.Id = Guid.NewGuid();

            foreach (var course in school.DevPrograms)
            {
                course.Id = Guid.NewGuid();
            }

            _context.Schools.Add(school);
        }

        public void DeleteProgram(DevProgram program)
        {
            if (program == null)
            {
                throw new ArgumentNullException(nameof(program));
            }

            _context.DevPrograms.Remove(program);

        }

        public void DeleteSchool(School school)
        {
            if (school == null)
            {
                throw new ArgumentNullException(nameof(school));
            }

            _context.Schools.Remove(school);
        }

        public DevProgram GetProgramById(Guid schoolId, Guid programId)
        {
            if (schoolId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(schoolId));
            }

            if (programId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(programId));
            }

            return _context.DevPrograms.
                Where(dp => dp.SchoolId == schoolId && dp.Id == programId).FirstOrDefault();
        }

        public IEnumerable<DevProgram> GetPrograms(Guid schoolId)
        {
            if (schoolId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(schoolId));
            }

            return _context.DevPrograms.
                Where(dp => dp.SchoolId == schoolId).ToList();
        }

        public School GetSchoolById(Guid schoolId)
        {
            if (schoolId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(schoolId));
            }

            return _context.Schools.
                Where(s => s.Id == schoolId).FirstOrDefault();
        }

        public IEnumerable<School> GetSchools()
        {
            return _context.Schools.ToList();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public bool SchoolExists(Guid schoolId)
        {
            if (schoolId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(schoolId));
            }

            return _context.Schools.Any(s => s.Id == schoolId);
        }

        public void UpdateProgram(DevProgram program)
        {
            // no code in this implementation
        }

        public void UpdateSchool(School school)
        {
            // no code in this implementation
        }
    }
}
