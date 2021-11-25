using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrintFromDatabaseWeb.Models
{
    public partial class Zawodnicy
    {
        public int IdZawodnika { get; set; }
        public int IdTrenera { get; set; }
        [Display(Name = "Imię")]
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Kraj { get; set; }
        [Display(Name = "Data urodzenia")]
        public DateTime DataUr { get; set; }
        public int Wzrost { get; set; }
        public decimal Waga { get; set; }
    }
}
