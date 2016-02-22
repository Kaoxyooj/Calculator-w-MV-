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
using Calculator_MV;

namespace Calculator_MV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel.Calculate Calculate = new ViewModel.Calculate();
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            //Result = Calculate.Answer;
        }
    }
}
