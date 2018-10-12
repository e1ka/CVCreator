using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CVCreator.Models
{
    public class Language
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Level { get; set; }
        [ForeignKey("Person")]
        public int Person_ID { get; set; }
        public virtual Person Person { get; set; }
    }
}