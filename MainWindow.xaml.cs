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

namespace GameLibary
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            ViewModel vm = new ViewModel();
            this.DataContext = vm;
            Mediator.getInstance().Vm = vm;
        }



        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Combobox sagt, dass sich was geändert hat. mediator hört zu. mediator holt sich gewähltes Spiel aus
            //Liste und dessen Zustand. aufgrund des zustandes en/diabled er buttons
            Mediator.getInstance().WidgetChanged(sender);
           
        }
    }
}
