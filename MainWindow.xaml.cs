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
using System.Collections.ObjectModel;

namespace WpfAppPOOArchP2C
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //LISTAS DE CLIENTES y CUNETAS
        public ObservableCollection<Cliente> lstClientes { get; set; }
        public ObservableCollection<CuentaBancaria> lstCtasB { get; set; }

        //VARIABLES DE INICIO DE LOS ID de Clientes y Ctas
        private int IdCliente = 111;
        private int IdCtaB = 150;
        public MainWindow()
        {
            InitializeComponent();

            lstClientes = new ObservableCollection<Cliente>();
            lstCtasB = new ObservableCollection<CuentaBancaria>();

            //CARGAR DATOS A LOS DATAGRIDS
            dgClientes.ItemsSource = lstClientes;
            dgCuentas.ItemsSource = lstCtasB;
        }

        private void btnAgregarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de cliente!!");
                return;
            }
            else
            {
                Cliente cli = new Cliente(IdCliente, txtCliente.Text);
                lstClientes.Add(cli);
                IdCliente++;
                txtCliente.Clear();
            }
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = dgClientes.SelectedItem as Cliente;
            lstClientes.Remove(cli);
        }

        private void btnAgregarCuenta_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = dgClientes.SelectedItem as Cliente;
            if(cli is null)
            {
                MessageBox.Show("NO ha escogido cliente...");
                return;
            }
            else
            {
                double saldo = double.Parse(txtCuentas.Text);
                if(saldo > 0)
                {
                    CuentaBancaria ctaB = new CuentaBancaria(IdCtaB, saldo);
                    cli.lstCtas.Add(ctaB); //lstCtas es la lista de Cuentas de la Clase Cliente
                    lstCtasB.Add(ctaB); //lstCtasB es la lista del dataGrid
                    IdCtaB++;
                    //dgClientes_SelectionChanged(null, null);
                    txtCuentas.Clear();
                }
                else
                {
                    MessageBox.Show("Ingrese un monto válido por favor...");
                }
            }
        }
    }
}
