﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Payroll.Entities
{
    [Table("department")]
    public class Department
    {
        public int DepartmentId { get; set; }

        [StringLength(250)]
        public string DepartmentName { get; set; }

        public bool IsActive { get; set; }
    }
}