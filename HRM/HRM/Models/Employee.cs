using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Employee code")]
        [StringLength(10)]
        public string EmployeeName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Father Name")]
        public string FatherNameName { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(10)]
        public string  PhoneNumber{ get; set; }

        public string ImagePath { get; set; }




        public int Designation { get; set; }

        [ForeignKey("Designation")]
        public virtual Designation Designations { get; set; }
    }
}