using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevSchoolApi.Entities
{
    public class School
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string SchoolName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        public ICollection<DevProgram> DevPrograms { get; set; }
            = new List<DevProgram>();
    }
}
