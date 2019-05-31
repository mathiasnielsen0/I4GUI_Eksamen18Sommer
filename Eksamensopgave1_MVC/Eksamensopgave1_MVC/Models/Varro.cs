using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Eksamensopgave1_MVC.Models
{
    public class Varro
    {
        [Key]
        public string VarroId { get; set; }

        [Required]
        public string Bistade { get; set; }
       
        public DateTime DatoRegistreret { get; set; }
        public uint AntalMider { get; set; }
        public uint ObservationsVarighed { get; set; }
        public string Notater { get; set; }

       
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
