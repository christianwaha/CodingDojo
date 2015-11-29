using Logic.Core;
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

namespace Client.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NumberConverter _converter = null;

        public MainWindow()
        {
            InitializeComponent();

            _converter = new NumberConverter();

            convertInput();
        }

        private void convertInput()
        {
            int value = 0;

            if (!int.TryParse(txb_Input.Text, out value))
            {
                txb_Output.Text = "Error";
            }
            else
            {
                txb_Output.Text = _converter.Convert(value);
            }
        }

        private void handleEvent_Button_Convert_Click(object sender, RoutedEventArgs e)
        {
            convertInput();
        }
    }
}
