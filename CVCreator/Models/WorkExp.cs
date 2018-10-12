using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CVCreator.Models
{
    public class WorkExp
    {
        public int ID { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string JobName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:y}", ApplyFormatInEditMode = true)]
        public DateTime FromDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:y}", ApplyFormatInEditMode = true)]
        public DateTime ToDate { get; set; }
        [ForeignKey("Person")]
        public int Person_ID { get; set; }
        public virtual Person Person { get; set; }
    }
}