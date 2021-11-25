using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrintFromDatabaseWeb.Models
{
    public partial class Skocznie
    {
        public int IdSkoczni { get; set; }
        public int IdMiasta { get; set; }
        public string KrajSkoczni { get; set; }
        public string NazwaSkoczni { get; set; }
        public int K { get; set; }
        public int Sedz { get; set; }
    }
}
