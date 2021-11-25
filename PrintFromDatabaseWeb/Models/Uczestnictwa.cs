using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrintFromDatabaseWeb.Models
{
    public partial class Uczestnictwa
    {
        public int IdUczestnictwa { get; set; }
        public int IdZawodnika { get; set; }
        public int IdZawodow { get; set; }
    }
}
