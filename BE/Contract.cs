using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Contract
    {
        public int ContractNum { get; set; }
        public string EmployerId  { get; set; }
        public string EmployeeId { get; set; }
        public bool IsInterview { get; set; }  
        public bool IsSign { get; set; }  
        public double HourSalaryG { get; set; } 
        public double HourSalaryN { get; set; }
        public DateTime DateBegingEmployin { get; set; }
        public DateTime DateEndEmploying { get; set; }
        public int HoursNum { get; set; }

        public override string ToString()  //Loading "ToStrint"
        {
            string str = string.Format("\nContractNum: {0} \nEmployerId: {1} \nEmploeeId: {2} \nHour Salary Gross: {3} \nHour Salary Net: {4} \nDate Beging Employin: {5}  \nDateEnd Emp loying: {6} \nHours Num: {7}  "
                , ContractNum, EmployerId, EmployeeId, HourSalaryG, HourSalaryN, DateBegingEmployin, DateEndEmploying, HoursNum);
            return str;
        }

    }
}
