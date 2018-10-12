using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using HtmlHelpers.BeginCollectionItem;
using System.ComponentModel.DataAnnotations;

namespace CVCreator.Models
{
    public class Education
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string SchoolName { get; set; }
        [Required]
        public string Degree { get; set; }
        [Required]
        public string Field { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:y}", ApplyFormatInEditMode = true)]
        public DateTime FromYear { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:y}", ApplyFormatInEditMode = true)]
        public DateTime ToYear { get; set; }
        [ForeignKey("Person")]
        public int Person_ID { get; set; }
        public virtual Person Person { get; set; }
    }
}