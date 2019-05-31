using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensopgave1.Classes
{
    public class VarroaTracker
    {
        public VarroaTracker()
        {
            VarroaRecords = new ObservableCollection<VarroaRecord>();
        }

        public ObservableCollection<VarroaRecord> GetVarroaCount()
        {
            return VarroaRecords;
        }

        public ObservableCollection<VarroaRecord> GetVarroaCount(string bistade)
        {
            ObservableCollection<VarroaRecord> temp = new ObservableCollection<VarroaRecord>();

            foreach (var r in VarroaRecords)
            {
                if (r.Bistade == bistade)
                    temp.Add(r);
            }

            return temp;
        }

        public void AddRecord(VarroaRecord r)
        {
            VarroaRecords.Add(r);
        }

        public void AddRecords(ObservableCollection<VarroaRecord> r)
        {
            VarroaRecords = r;
        }

        private ObservableCollection<VarroaRecord> VarroaRecords { get; set; }

    }
}
