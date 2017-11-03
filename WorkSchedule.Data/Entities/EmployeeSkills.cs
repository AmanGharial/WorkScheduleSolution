using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Data.Entities
{
    [Table("EmployeeSkills")]
    public class EmployeeSkills
    {
        [Key]
        public int EmployeeSkillID { get; set; }
        public int EmployeeID { get; set; }
        public int SkillID { get; set; }
        [Required(ErrorMessage = "Level is required.")]
        public int Level { get; set; }
        public int? YearsOfExperience { get; set; }

        [Required(ErrorMessage = "Hourly Wage is required.")]
        public decimal HourlyWage { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
