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
    public class EmployeesController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Employees> ListAllEmployee()
        {
            using (var context = new WorkScheduleContext())
            {
                return context.Employee.ToList();
            }
        }

        


    }
}
