using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSchedule.Data.Entities;
using WorkSchedule.System.DAL;

namespace WorkSchedule.System.BLL
{
    [DataObject]
    public class SkillsController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Skills> ListAllSkills()
        {
            using (var context = new WorkScheduleContext())
            {
                return context.Skills.ToList();
            }
        }

    }
}
