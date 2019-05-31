using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Eksamensopgave1.Annotations;
using Eksamensopgave1.Classes;

namespace Eksamensopgave1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private FileManager _fileManager;
        private VarroaTracker _Tracker;
        private ObservableCollection<VarroaRecord> _records;
        private ObservableCollection<VarroaRecord> _recordsByHive;

        #region Properties
        public ObservableCollection<VarroaRecord> VarroaRecords
        {
            get { return _records; }
            set
            {
                if (_records != value)
                {
                    _records = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<VarroaRecord> VarroaRecordsByHive
        {
            get { return _recordsByHive; }
            set
            {
                if (_recordsByHive != value)
                {
                    _recordsByHive = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region WindowInitalizer
        public MainWindow()
        {
            InitializeComponent();
            _Tracker = new VarroaTracker();
            _records = new ObservableCollection<VarroaRecord>();
            _recordsByHive = new ObservableCollection<VarroaRecord>();
            string path = Directory.GetCurrentDirectory() + "/VarroaRecords.txt";
            _fileManager = new FileManager(path);
            _Tracker.AddRecords(_fileManager.ReadFromFile());
            VarroaRecords = _Tracker.GetVarroaCount();
            DataGridRecords.ItemsSource = VarroaRecords;
            DataContext = this;
        }
        #endregion

        #region EventHandlers
        private void BtnEnterRcdClick(object sender, RoutedEventArgs e)
        {
            VarroaRecord tempRecord = new VarroaRecord();

            AddRecordWindow AddRcdWnd = new AddRecordWindow();
            AddRcdWnd.Owner = this;

            if (AddRcdWnd.ShowDialog() == true)
            {
                tempRecord = AddRcdWnd.Record;
            }
            if(tempRecord != null)
            VarroaRecords.Add(tempRecord);
            DataGridRecords.ItemsSource = VarroaRecords;
        }

        private void BtnGetRecordsClick(object sender, RoutedEventArgs e)
        {
            DataGridRecords.ItemsSource = VarroaRecords;
        }

        private void BtnGetRecordsByHiveClick(object sender, RoutedEventArgs e)
        {
            VarroaRecordsByHive = new ObservableCollection<VarroaRecord>();
            foreach (var r in VarroaRecords)
            {
                if (r.Bistade == TxtBoxHive.Text)
                {
                    VarroaRecordsByHive.Add(r);
                }
            }

            DataGridRecords.ItemsSource = VarroaRecordsByHive;
        }
      
        private void BtnAddSeeds(object sender, RoutedEventArgs e)
        {
            VarroaRecords.Add(new VarroaRecord("A38F", DateTime.Now, 58, "Test1"));
            VarroaRecords.Add(new VarroaRecord("Y6YX", DateTime.Now, 102, "Test2"));
            VarroaRecords.Add(new VarroaRecord("HYC3", DateTime.Now, 6, "Test3"));
            VarroaRecordsByHive.Add(new VarroaRecord("A38F", DateTime.Now, 58, "Test1"));
            VarroaRecordsByHive.Add(new VarroaRecord("Y6YX", DateTime.Now, 102, "Test2"));
            VarroaRecordsByHive.Add(new VarroaRecord("HYC3", DateTime.Now, 6, "Test3"));
        }

        private void BtnSaveRcd(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_fileManager.WriteToFile(VarroaRecords) ? "Saved records" : "Failed to save records");
        }

        private void BtnClearRcd(object sender, RoutedEventArgs e)
        {
            VarroaRecords.Clear();
            MessageBox.Show(_fileManager.ClearFile() ? "Cleared records" : "Failed to delete records");
        }

        private void BtnExit(object sender, RoutedEventArgs e)
        {
            Close();
        } 
        #endregion

        #region INotifyProperty
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        
    }
}
