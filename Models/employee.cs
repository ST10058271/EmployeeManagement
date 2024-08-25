using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        // Auto-generated ID
        public int ID { get; set; }

        // Employee Name - Required field
        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }

        // Employee Email - Required field and valid email format
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }

        // Employee Department - Required field
        [Required(ErrorMessage = "Department is required.")]
        public string? Department { get; set; }

        // Hire Date - Required field, DataType to specify date format
        [Required(ErrorMessage = "Hire Date is required.")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}
