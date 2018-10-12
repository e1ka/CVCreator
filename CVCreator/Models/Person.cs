using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CVCreator.Models
{
    public class Person
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:y}", ApplyFormatInEditMode = true)]
        public DateTime Birth { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }

        public Person()
        {
            Educations = new List<Education>();
            Experiences = new List<WorkExp>();
            Skills = new List<Skill>();
            Languages = new List<Language>();
            Certifications = new List<Certification>();
        }
        public virtual IList<Education> Educations { get; set; }
        public virtual ICollection<WorkExp> Experiences { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<Language> Languages { get; set; }
        public virtual ICollection<Certification> Certifications { get; set; }
    }
}