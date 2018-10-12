using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CVCreator.Models
{
    public class Certification
    {
        public int ID { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:y}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [ForeignKey("Person")]
        public int Person_ID { get; set; }
        public virtual Person Person { get; set; }
    }
}