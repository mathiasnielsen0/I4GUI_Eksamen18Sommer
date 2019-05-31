using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Eksamensopgave1_MVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        [MaxLength(5)]
        public string DBFnummer { get; set; }

        public string AddresseLinje1 { get; set; }
        public string AddresseLinje2 { get; set; }
        public uint Postnummer { get; set; }
        public string By { get; set; }


        public List<Varro> Varros { get; set; }
    }
}
