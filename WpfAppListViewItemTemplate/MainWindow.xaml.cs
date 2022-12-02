using System;
using System.Collections.Generic;
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

namespace WpfAppListViewItemTemplate
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<UserModel> Users { get; set; } = new List<UserModel> 
        {  
            new UserModel(){ FirstName="Валя", SurnameName="Новикова"},
            new UserModel(){ FirstName="Таня", SurnameName="Шупикова"},
            new UserModel(){ FirstName="Костя", SurnameName="Высоцкий"},
        };

        public List<string> People { get; set; } = new List<string>
        {
            "Александр",
            "Александр",
            "Евгений"
        };

        public string User { get; set; } = "Fsdsdfsdf";
     
        
        public MainWindow()
        {

        User = "1111";

        InitializeComponent();

        DataContext = this;
        }

    }
}