using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Division
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int Id { get; set; }

        [Display(Name = "Divition Code")]

        public int DivusionCode { get; set; }
        [Display(Name = "Divition Name")]

        public string Name { get; set; }
    }
}