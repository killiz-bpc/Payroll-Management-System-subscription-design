using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Management_System.Connections
{
    public static class GetPayslipDetails
    {

        public static string employee_name {  get; set; }
        public static string job_title { get; set; }
        public static string department { get; set; }

        public static double basic_salary { get; set; }
        public static double addition_overtime { get; set; }
        public static double addition_nightpremium { get; set; }
        public static double addition_restdayduty { get; set; }
        public static double addition_legalholiday { get; set; }
        public static double addition_specialholiday { get; set; }
        public static double deduction_late { get; set; }
        public static double deduction_undertime { get; set; }
        public static double deduction_absent { get; set; }
        public static double hmo { get; set; }


    }
}
