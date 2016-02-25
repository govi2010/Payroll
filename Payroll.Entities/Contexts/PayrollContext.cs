﻿using System.Configuration;
using System.Data.Entity;
using Payroll.Entities.Payroll;
using Payroll.Entities.Users;

namespace Payroll.Entities.Contexts
{
    //[DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class PayrollContext : DbContext
    {

        public PayrollContext() : base(ConnectionString)
        {
            Database.SetInitializer<PayrollContext>(null);
        }

        public virtual IDbSet<Employee> Employees { get; set; }
        public virtual IDbSet<Attendance> Attendances { get; set; }
        public virtual IDbSet<Department> Departments { get; set; }
        public virtual IDbSet<DepartmentManager> DepartmentManagers { get; set; }
        public virtual IDbSet<EmployeeDepartment> EmployeeDepartments { get; set; }
        public virtual IDbSet<EmployeeFile> EmployeeFiles { get; set; }
        public virtual IDbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public virtual IDbSet<EmployeeWorkSchedule> EmployeeWorkSchedules { get; set; }
        public virtual IDbSet<Files> Files { get; set; }
        public virtual IDbSet<Frequency> Frequencies { get; set; }
        public virtual IDbSet<Holiday> Holidays { get; set; }
        public virtual IDbSet<Leave> Leaves { get; set; }
        public virtual IDbSet<Loan> Loans { get; set; }
        public virtual IDbSet<LoanPayment> LoanPayments { get; set; }
        public virtual IDbSet<PaymentFrequency> PaymentFrequencies { get; set; }
        public virtual IDbSet<Position> Positions { get; set; }
        public virtual IDbSet<Schedule> Schedules { get; set; }
        public virtual IDbSet<Setting> Settings { get; set; }
        public virtual IDbSet<Tax> Taxes { get; set; }
        public virtual IDbSet<WorkSchedule> WorkSchedules { get; set; }
        public virtual IDbSet<AttendanceLog> AttendanceLog { get; set; }

        //Payroll
        public virtual IDbSet<Deduction> Deductions { get; set; }
        public virtual IDbSet<EmployeeAdjustment> EmployeeAdjustments { get; set; }
        public virtual IDbSet<EmployeeLeave> EmployeeLeaves { get; set; }
        public virtual IDbSet<EmployeeLoan> EmployeeLoans { get; set; }
        public virtual IDbSet<Payroll.Payroll> Payrolls { get; set; }
        public virtual IDbSet<EmployeeHours> EmployeeHours { get; set; }

        //Users
        public virtual IDbSet<Role> Roles { get; set; }
        public virtual IDbSet<User> Users { get; set; }
        public virtual IDbSet<UserClaim> UserClaims { get; set; }
        public virtual IDbSet<UserLogin> UserLogIns { get; set; }
        public virtual IDbSet<UserRole> UserRoles { get; set; }

        static string ConnectionString
        {

            get
            {
                string cs = "";
                switch (ConfigurationManager.AppSettings["DatabaseType"])
                {
                    case "MsSql":
                        cs = "ConnectionString.MsSql";
                        break;
                    case "MySql":
                        cs = "ConnectionString.MySql";
                        break;
                }

                return cs;
            }
        }

    }
}
