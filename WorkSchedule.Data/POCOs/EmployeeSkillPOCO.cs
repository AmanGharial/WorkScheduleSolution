using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSchedule.Data.POCOs
{
    public class EmployeeSkillPOCO
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public string SkillLevel { get; set; }
        public int? YOE { get; set; }

        //private int _YOE;
        //public int? YOE
        //{
        //    get
        //    {
        //        return _YOE;
        //    }
        //    set
        //    {
        //        if(string.IsNullOrEmpty(value.ToString()))
        //        {
        //            _YOE = 0;
        //        }
        //        else
        //        {
        //            _YOE = int.Parse(value.ToString());
        //        }
        //    }
        //}
    }
}
