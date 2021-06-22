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
using System.Xml.Linq;
using WpfApp3.Model;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public BuyerSearch SelectedName;
        
        private IEnumerable<Buyer> _BuyerList = null;

        public event PropertyChangedEventHandler PropertyChanged;
        private void Invalidate()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("BuyerList"));
        }

        public IEnumerable<Buyer> BuyerList {
            get
            {
                var Result = _BuyerList;
                if(SelectedName!=null)
                    Result = Result.Where(c => (SelectedName.Title == "Все статусы" || c.Type == SelectedName.Title));
              

                // если фильтр не пустой, то ищем ВХОЖДЕНИЕ подстроки поиска в кличке без учета регистра
                if (SearchFilter != "")
                    Result = Result.Where(c => c.Name.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0);
                if (SortAsc) Result = Result.OrderBy(c => c.Age);
                else Result = Result.OrderByDescending(c => c.Age);

                return Result;



            }
            set
            {
                _BuyerList = value;
            }
        }
        public List<BuyerSearch> BuyerSearchList { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Globals.dataProvider = new DataProvider(@"../../buyers.xml");
            BuyerList = Globals.dataProvider.GetBuyers();
            BuyerSearchList = Globals.dataProvider.GetBuyerSearch().ToList();
            BuyerSearchList.Insert(0, new BuyerSearch { Title = "Все статусы" });
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NameFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedName = NameFilterComboBox.SelectedItem as BuyerSearch;
            Invalidate();                        
        }

        private string SearchFilter = "";
        private void SearchFilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
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

