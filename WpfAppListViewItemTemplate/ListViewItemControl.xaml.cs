using System.Windows;
using System.Windows.Controls;

namespace WpfAppListViewItemTemplate
{
    /// <summary>
    /// Логика взаимодействия для ListViewItemControl.xaml
    /// </summary>
    public partial class ListViewItemControl : UserControl
    {

        public Image Icon
        {
            get { return (Image)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(Image), typeof(ListViewItemControl), new PropertyMetadata());



        public UIElement Description
        {
            get { return (UIElement)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Description.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(UIElement), typeof(ListViewItemControl), new PropertyMetadata(0));



        public ListViewItemControl()
        {
            InitializeComponent();
        }
    }
}
