using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Designation
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "short Name")]
        public string Shortname { get; set; }

        [Display(Name = "Designation Name")]
        public string DesignationName { get; set; }


        [Display(Name = "Full Designation Name")]
        public string FullDesignationName { get; set; }



        public List<Employee> Employees { get; set; }
    }
    
}