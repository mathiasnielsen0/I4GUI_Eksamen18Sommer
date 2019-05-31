using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;
using Eksamensopgave1.Annotations;
using Eksamensopgave1.Classes;

namespace Eksamensopgave1
{
    /// <summary>
    /// Interaction logic for AddRecordWindow.xaml
    /// </summary>
    public partial class AddRecordWindow : Window, INotifyPropertyChanged
    {
        public VarroaRecord Record { get; set; }

        public AddRecordWindow()
        {
            InitializeComponent();
            Record = new VarroaRecord();
            Record.Date = DateTime.Now;
            DataContext = this;
        }

        private string _bistade;
        public string Bistade
        {
            get { return _bistade; }
            set
            {
                if (_bistade != value)
                {
                    Record.Bistade = value;
                    _bistade = value;
                    OnPropertyChanged();
                }
            }
        }

        private uint _count;
        public uint Count
        {
            get { return _count; }
            set
            {
                if (_count != value)
                {
                    Record.Varrocount = value;
                    _count = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _note;
        public string Note
        {
            get { return _note; }
            set
            {
                if (_note != value)
                {
                    Record.Note = value;
                    _note = value;
                    OnPropertyChanged();
                }
                
            }
        }

        private void BtnSave(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }


        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion  
    }
}
