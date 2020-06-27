using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebDevSchoolApi.Entities
{
    public class DevProgram
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string ProgramName { get; set; }

        public DateTime ClosestStartDate { get; set; }

        public string Description { get; set; }

        [ForeignKey("SchoolId")]
        public School School { get; set; }

        public Guid SchoolId { get; set; }

    }
}
