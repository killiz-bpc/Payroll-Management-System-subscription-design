using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Management_System.Connections
{
    public static class Payslip
    {

        public static bool isSaved { get; set; }
        public static int emp_id { get; set; }
        public static string attendance_batch_no { get; set; }
        public static string cutoff_period { get; set; }
        public static string employee_name {  get; set; }
        public static string job_title { get; set; }
        public static double basic_salary { get; set; }
        public static string department { get; set; }
        public static double addition_overtime { get; set; }
        public static double addition_nightpremium { get; set; }
        public static double addition_restdayduty { get; set; }
        public static double addition_legalholiday { get; set; }
        public static double addition_specialholiday { get; set; }
        public static double deduction_late { get; set; }
        public static double deduction_undertime { get; set; }
        public static double deduction_absent { get; set; }
        public static double deduction_hmo { get; set; }
        public static double deduction_sss { get; set; }
        public static double deduction_philhealth { get; set; }
        public static double deduction_pagibig { get; set; }

        public static double gross_pay {  get; set; }   





    }
}
