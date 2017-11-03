using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Data.Entities
{
    [Table("Skills")]
    public class Skills
    {
        [Key]
        public int SkillID { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [StringLength(100, ErrorMessage = "Description is limited to 100 characters.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "RequiresTicket is required.")]
        public bool RequiresTicket { get; set; }
        public virtual ICollection<EmployeeSkills> EmployeeSkill { get; set; }
    }
}
