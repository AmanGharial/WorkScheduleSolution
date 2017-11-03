using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSchedule.Data.Entities;
using WorkSchedule.Data.POCOs;
using WorkSchedule.System.DAL;

namespace WorkSchedule.System.BLL
{
    [DataObject]
    public class EmployeeSkillsController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<EmployeeSkills> ListAllSkills()
        {
            using (var context = new WorkScheduleContext())
            {
                return context.EmployeeSkills.ToList();
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]


        public List<EmployeeSkillPOCO> EmployeeSkillReport_Get(int value)
        {
            using (var context = new WorkScheduleContext())
            {
                var results = from x in context.EmployeeSkills
                              where x.SkillID == value
                              orderby x.Skill.Description
                              select new EmployeeSkillPOCO()
                              {
                                  Name = x.Employee.LastName + ", " + x.Employee.FirstName,
                                  Phone = x.Employee.HomePhone,
                                  Active = x.Employee.Active,
                                  SkillLevel = x.Level == 1 ? "Novice" : x.Level == 2 ? "Proficient" : "Expert",
                                  YOE = x.YearsOfExperience
                              };
                return results.ToList();
            }
        }//eom

    }

   
}

//The EmployeeSkillsController will have a method which will recieve an integer parameter representing a skill and return all employees with that skill
