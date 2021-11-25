using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrintFromDatabaseWeb.Models
{
    public partial class Trenerzy
    {
        public int IdTrenera { get; set; }
        public string ImieT { get; set; }
        public string NazwiskoT { get; set; }
        public DateTime DataUrT { get; set; }
    }
}
