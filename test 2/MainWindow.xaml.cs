using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using test_2.model;

namespace test_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Tạo ViewModel và gán dữ liệu cho ListBox
            ViewModel viewModel = new ViewModel();
            lstLop.ItemsSource = viewModel.DanhSachLop;
        }

        private void click(object sender, MouseButtonEventArgs e)
        {
            // Tìm TextBlock có tên "clas" trong StackPanel
            StackPanel stackPanel = sender as StackPanel;
            if (stackPanel != null)
            {
                // Tìm TextBlock bên trong StackPanel có x:Name="clas"
                TextBlock tbx = stackPanel.FindName("clas") as TextBlock;

                if (tbx != null)
                {
                    // Đổi Visibility của TextBlock
                    tbx.Visibility = tbx.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
                }
            }
        }

    }
}