using CVCreator.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CVCreator.DAL
{
    public class CVCreatorDbInitializer : DropCreateDatabaseIfModelChanges<CVCreatorDbContext>
    {
        protected override void Seed(CVCreatorDbContext context)
        {
            var persons = new List<Person>
            {
                new Person
                {
                    Name = "Anna Maria",
                    Surname = "Kowalska",
                    Birth = DateTime.Parse("1992-10-09"),
                    Telephone = "500200100",
                    Email = "kowalska@vp.pl",
                    Country = "Poland",
                    City = "Katowice",
                    Educations = new List<Education> {
                        new Education { SchoolName = "ATH", Degree = "Engineer", Field = "Zarządzanie i Inżynieria Produkcji", FromYear = DateTime.Parse("2014-10-10"), ToYear = DateTime.Parse("2018-06-06")},
                        new Education { SchoolName = "I LO im. M.Kopernika w Bielsku-Białej", Degree = "brak", Field ="mat-geo-ang", FromYear = DateTime.Parse("2010-09-01"), ToYear = DateTime.Parse("2014-06-06")}},
                    Experiences = new HashSet<WorkExp> {
                        new WorkExp { CompanyName = "ZARA", JobName = "Obsługa klienta", FromDate = DateTime.Parse("2014-10-10"), ToDate = DateTime.Now}},
                    Languages = new HashSet<Language> {
                        new Language { Name = "Angielski", Level = "Bardzo dobry" }},
                    Skills = new HashSet<Skill> {
                        new Skill { Name = "Obsługa komputera", Level = "Bardzo dobra" },
                        new Skill { Name = "Prawo Jazdy kat.B", Level="brak"},
                        new Skill { Name = "Rysunki techniczne", Level = "Bardzo dobrze"}},
                    Certifications = new HashSet<Certification> {
                        new Certification { Company = "Darmowe Certyfikaty", Title = "Dobry człowiek", Date = DateTime.Now }}
                },
                new Person
                {
                    Name = "Adrian",
                    Surname = "Nowak",
                    Birth = DateTime.Parse("1994-10-09"),
                    Telephone = "501200101",
                    Email = "nowak@vp.pl",
                    Country = "Poland",
                    City = "Żywiec",
                    Educations = new List<Education> {
                        new Education { SchoolName = "ATH", Degree = "Engineer", Field = "Automatyka i Robotyka", FromYear = DateTime.Parse("2014-10-01"), ToYear = DateTime.Parse("2018-06-06")},
                        new Education { SchoolName = "Zespół Szkół Elektronicznych, Elektrycznych i Mechanicznych im. Jędrzeja Śniadeckiego w Bielsku-Białej ", Degree = "Technik mechatronik", Field ="Mechatronika", FromYear = DateTime.Parse("2009-09-01"), ToYear = DateTime.Parse("2014-06-06")}},
                    Experiences = new HashSet<WorkExp> {
                        new WorkExp { CompanyName = "MCD Electronics sp. z o.o.", JobName = "Programista C", FromDate = DateTime.Parse("2014-10-10"), ToDate = DateTime.Now}},
                    Languages = new HashSet<Language> {
                        new Language { Name = "Angielski", Level = "Bardzo dobry" }},
                    Skills = new HashSet<Skill> {
                        new Skill { Name = "C", Level = "Bardzo dobra" },
                        new Skill { Name = "C++", Level="Dobry"},
                        new Skill { Name = "Linux", Level = "Dobry"}},
                    Certifications = new HashSet<Certification> {
                        new Certification { Company = "ATH", Title = "Programista PLC", Date = DateTime.Now }}
                },
                new Person
                {
                    Name = "Kasia",
                    Surname = "Kowalska",
                    Birth = DateTime.Parse("1992-10-09"),
                    Telephone = "500200123",
                    Email = "kowalska123@vp.pl",
                    Country = "Poland",
                    City = "Katowice",
                    Educations = new List<Education> {
                        new Education { SchoolName = "ATH", Degree = "Engineer", Field = "Zarządzanie i Inżynieria Produkcji", FromYear = DateTime.Parse("2014-10-10"), ToYear = DateTime.Parse("2018-06-06")},
                        new Education { SchoolName = "I LO im. M.Kopernika w Bielsku-Białej", Degree = "brak", Field ="mat-geo-ang", FromYear = DateTime.Parse("2010-09-01"), ToYear = DateTime.Parse("2014-06-06")}},
                    Experiences = new HashSet<WorkExp> {
                        new WorkExp { CompanyName = "New Yorker", JobName = "Obsługa klienta", FromDate = DateTime.Parse("2014-10-10"), ToDate = DateTime.Now}},
                    Languages = new HashSet<Language> {
                        new Language { Name = "Angielski", Level = "Bardzo dobry" }},
                    Skills = new HashSet<Skill> {
                        new Skill { Name = "Obsługa komputera", Level = "Bardzo dobra" },
                        new Skill { Name = "Prawo Jazdy kat.B", Level="brak"},
                        new Skill { Name = "Rysunki techniczne", Level = "Bardzo dobrze"}},
                    Certifications = new HashSet<Certification> {
                        new Certification { Company = "Darmowe Certyfikaty", Title = "Dobry człowiek", Date = DateTime.Now }}
                },
                new Person
                {
                    Name = "Dominik",
                    Surname = "Duda",
                    Birth = DateTime.Parse("1995-10-09"),
                    Telephone = "508200123",
                    Email = "dudaduda@vp.pl",
                    Country = "Poland",
                    City = "Cieszyn",
                    Educations = new List<Education> {
                        new Education { SchoolName = "ATH", Degree = "Engineer", Field = "Informatyka", FromYear = DateTime.Parse("2014-10-10"), ToYear = DateTime.Parse("2018-06-06")},
                        new Education { SchoolName = "II LO im. A. Asnyka w Bielsku", Degree = "brak", Field ="mat-inf-ang", FromYear = DateTime.Parse("2010-09-01"), ToYear = DateTime.Parse("2014-06-06")}},
                    Languages = new HashSet<Language> {
                        new Language { Name = "Angielski", Level = "Bardzo dobry" },
                        new Language { Name = "Niemiecki", Level = "Bardzo dobry" }},
                    Skills = new HashSet<Skill> {
                        new Skill { Name = "C#", Level = "Bardzo dobra" },
                        new Skill { Name = "C++", Level="Dobra"},
                        new Skill { Name = "Java", Level = "Dobra"}},
                    Certifications = new HashSet<Certification> {
                        new Certification { Company = "Darmowe Certyfikaty", Title = "Programista Python", Date = DateTime.Now }}
                },
                new Person
                {
                    Name = "Szymon",
                    Surname = "Kula",
                    Birth = DateTime.Parse("1998-10-09"),
                    Telephone = "500200333",
                    Email = "kuladajefula@vp.pl",
                    Country = "Poland",
                    City = "Katowice",
                    Educations = new List<Education> {
                        new Education { SchoolName = "ATH", Degree = "Engineer", Field = "Zarządzanie i Inżynieria Produkcji", FromYear = DateTime.Parse("2014-10-10"), ToYear = DateTime.Parse("2015-06-06")} },
                    Experiences = new HashSet<WorkExp> {
                        new WorkExp { CompanyName = "Szlachta nie pracuje", JobName = "Raper", FromDate = DateTime.Parse("2014-10-10"), ToDate = DateTime.Now}},
                    Languages = new HashSet<Language> {
                        new Language { Name = "Angielski", Level = "Dobry" }},
                    Skills = new HashSet<Skill> {
                        new Skill { Name = "Obsługa komputera", Level = "Bardzo dobra" }},
                    Certifications = new HashSet<Certification> {
                        new Certification { Company = "WSRH", Title = "Raper podziemia", Date = DateTime.Now }}
                }
            };
            persons.ForEach(p => context.Persons.Add(p));
            context.SaveChanges();
        }
    }
}