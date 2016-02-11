﻿using Payroll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Service.Interfaces
{
    public interface IEmployeeService
    {
        IList<Employee> GetActiveByPaymentFrequency(int PaymentFrequencyId);
    }
}
