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

namespace SimpleWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public delegate void ProgressBarDelegate(System.Windows.DependencyProperty dp, Object value);

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void best_button_Click(object sender, RoutedEventArgs e)
        {
            double progress = 0;

            ProgressBarDelegate updatePbDelegate =
                new ProgressBarDelegate(prog_bar.SetValue);

            do
            {
                progress++;

                Dispatcher.Invoke(updatePbDelegate,
                    System.Windows.Threading.DispatcherPriority.Background,
                    new object[] { ProgressBar.ValueProperty, progress });
                prog_bar.Value = progress;
            }
            while (prog_bar.Value != prog_bar.Maximum);

            check_box.IsEnabled = true;
        }
    }
}
