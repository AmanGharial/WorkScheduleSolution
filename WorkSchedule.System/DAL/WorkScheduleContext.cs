using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkSchedule.Data.Entities;

namespace WorkSchedule.System.DAL
{
    internal class WorkScheduleContext : DbContext
    {
        public WorkScheduleContext() : base("WorkScheduleDb")
        {

        }

        public DbSet<Employees> Employee { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<EmployeeSkills> EmployeeSkills { get; set;}


    }
}
