using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eksamensopgave1.Classes
{
    public class FileManager
    {
        public FileManager(string filePath)
        {
            FilePath = filePath;
        }

        public bool ClearFile()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                    File.Create(FilePath);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to write to file");
                return false;
            }

            return true;
        }


        public bool WriteToFile(ObservableCollection<VarroaRecord> records)
        {
            try
            {
                File.WriteAllText(FilePath, StringifyRecords(records));
            }
            catch(Exception)
            {
                Console.WriteLine("Failed to write to file");
                return false;
            }

            return true;
        }

        
            
         public ObservableCollection<VarroaRecord> ReadFromFile()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    return DeStringifyRecords(File.ReadAllText(FilePath));
                }
                return new ObservableCollection<VarroaRecord>();
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to read from file");
                return new ObservableCollection<VarroaRecord>();
            }
        }
        private string StringifyRecords(ObservableCollection<VarroaRecord> records)
        {
            string temp = "";

            foreach (var r in records)
            {
                temp += r.Bistade + ",";
                temp += r.Note + ",";
                temp += r.Date.ToString() + ",";
                temp += r.Varrocount.ToString() + ";";
            }

            return temp;
        }

        private ObservableCollection<VarroaRecord> DeStringifyRecords(String records)
        {
            ObservableCollection<VarroaRecord> tempRecordObservableCollection = new ObservableCollection<VarroaRecord>();
            VarroaRecord tempRecord = new VarroaRecord();
            uint IsNewElement = 0;
            string tempString = "";

            for (int i = 0; i < records.Length; i++)
            {
                if (records[i] == ';')
                {
                    tempRecord.Varrocount = uint.Parse(tempString);

                    tempRecordObservableCollection.Add(tempRecord);
                    tempRecord = new VarroaRecord();
                    tempString = "";
                    IsNewElement = 0;
                }
                else if (records[i] == ',')
                {
                    switch (IsNewElement)
                    {
                        case 0:
                            tempRecord.Bistade = tempString;
                            break;

                        case 1:
                            tempRecord.Note = tempString;
                            break;

                        case 2:
                            tempRecord.Date = Convert.ToDateTime(tempString);
                            break;
                    }

                    ++IsNewElement;
                    tempString = "";
                }
                else
                {
                    tempString += records[i];
                }
            }

            return tempRecordObservableCollection;

        }

        private string FilePath;

    }
}
