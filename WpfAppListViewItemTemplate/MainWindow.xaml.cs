using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppListViewItemTemplate
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public ObservableCollection<UserModel> Users { get; set; } = new ObservableCollection<UserModel>
        {
            new UserModel(){ FirstName="Валя", SurName="Новикова"},
            new UserModel(){ FirstName="Таня", SurName="Шупикова"},
            new UserModel(){ FirstName="Костя", SurName="Высоцкий"},
        };

        public List<string> People { get; set; } = new List<string>
        {
            "Александр",
            "Александр",
            "Евгений"
        };

        public string User { get; set; } = "Fsdsdfsdf";


        private UserModel _SelectedUser;

        public UserModel SelectedUser
        {
            get { return _SelectedUser; }
            set {
                _SelectedUser = value;
                OnPropertyChanged();

            //    MessageBox.Show("SelectedUser.FirstName = " + value.FirstName);
            }
        }


        public MainWindow()
        {

            User = "1111";

            InitializeComponent();

            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}