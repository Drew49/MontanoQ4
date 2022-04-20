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

namespace MontanoQ4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EnergyTypeBase [] energyTypes = new EnergyTypeBase [3];
        private int index;
        public MainWindow()
        {
            InitializeComponent();
            energyTypes[0] = new Gasoline();
            energyTypes[1] = new Ethanol();
            energyTypes[2] = new Methanol();

        }

        private void btnGetInfo_Click(object sender, RoutedEventArgs e)
        {
            if (rbGasoline.IsChecked == true)
            {
                index = 0;
            }
            if (rbEthanol.IsChecked == true)
            {
                index = 1;
            }
            if (rbMethanol.IsChecked == true)
            {
                index = 2;
            }

            tbxInfo.Text = energyTypes[index].GetName() + " is a " + energyTypes[index].GetEnergyType() + " fuel. " +
                " It's specific energy is " + energyTypes[index].GetSpecificEnergy() + " M3/kg. " +
                " It's energy density is " + energyTypes[index].GetEnergyDenisty() + " MMJ/L.";
        }
    }

    
}
