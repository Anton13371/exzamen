using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
using WpfApp777.Model;

namespace WpfApp777
{
    public partial class MainWindow : Window, INotifyPropertyChanged

    {
        public string SelectedPosition = "";

        private IEnumerable<Worker> _WorkerList = null;
        public IEnumerable<Worker> WorkerList
        {
            get
            {
                var res = _WorkerList;

                res = res.Where(c => (SelectedPosition == "Все должности" || c.Position == SelectedPosition));
                if (SearchFilter != "")
                    res = res.Where(c => c.Name.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0);
                if (SortAsc) res = res.OrderBy(c => c.Age);
                else res = res.OrderByDescending(c => c.Age);

                return res;
            }
            set
            {
                _WorkerList = value;
            }

        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Globals.dataProvider = new LocalDataProvider();
            WorkerList = Globals.dataProvider.GetWorkers();
            WorkerPositionList = Globals.dataProvider.GetWorkerPositions().ToList();
            WorkerPositionList.Insert(0, new WorkerPosition { Title = "Все должности" });
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public List<WorkerPosition> WorkerPositionList { get; set; }

        private void BreedFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedPosition = (BreedFilterComboBox.SelectedItem as WorkerPosition).Title;
            Invalidate();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void Invalidate()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("WorkerList"));
        }
        private string SearchFilter = "";

        private void SearchFilter_KeyUp(object sender, KeyEventArgs e)
        {
            SearchFilter = SearchFilterTextBox.Text;
            Invalidate();
        }
        private bool SortAsc = true;

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SortAsc = (sender as RadioButton).Tag.ToString() == "1";
            Invalidate();
        }
    }

}
