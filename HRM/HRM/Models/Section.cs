using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Section
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int SectionCode { get; set; }
        public int SectionName { get; set; }

        public int DeptsId { get; set; }

        [ForeignKey("DeptsId")]
        public virtual Dept Depts { get; set; }



    }
}