using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Dept
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int DeptCode { get; set; }
        public int DeptName { get; set; }

        public int DivisionId { get; set; }

        [ForeignKey("DivisionId")]
        public virtual Division Divisions { get; set; }

    }
}