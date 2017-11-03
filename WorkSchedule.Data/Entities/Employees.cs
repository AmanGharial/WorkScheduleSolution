using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Data.Entities
{
    [Table("Employees")]
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "FirstName is required.")]
        [StringLength(50, ErrorMessage = "FirstName is limited to 50 characters.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required.")]
        [StringLength(50, ErrorMessage = "Lastname is limited to 50 characters.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "HomePhone is required.")]
        [StringLength(12, ErrorMessage = "HomePhone is limited to 12 characters.")]
        public String HomePhone { get; set; }
        [Required(ErrorMessage = "Active is required.")]
        public bool Active { get; set; }

        public virtual ICollection<EmployeeSkills> EmployeeSkill { get; set; }
    }
}
