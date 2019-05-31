using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensopgave1.Classes
{
    public class VarroaRecord
    {
        public VarroaRecord(string bistade, DateTime date, uint count, string note)
        {
            Bistade = bistade;
            Date = date;
            Varrocount = count;
            Note = note;
        }

        public VarroaRecord()
        {
        }


        public string Bistade { get; set; }
        public DateTime Date { get; set; }
        public uint Varrocount { get; set; }
        public string Note { get; set; }

    }
}
