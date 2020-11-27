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

namespace Examen2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Paquete> comprados;
        List<Paquete> reservados;
        Cliente client;
        Cliente cliente1;
        Cliente cliente2;
        Cliente cliente3;
        Cliente cliente4;
        Cliente cliente5;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Cliente client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 

            if (client == null)
            {
                MessageBox.Show("No ha introducido ningun cliente");
            }
            else {

                this.Hide();

                Form2 f1 = new Form2(client.paquetes_comprados, client.paquetes_reservados, this, client);

                f1.Show();
            }
        }

        private void lb_principal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            client = (Cliente) lb_principal.SelectedItem;
            
            
            
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comprados = new List<Paquete>();
            reservados = new List<Paquete>();
            cliente1 = new Cliente("Pepe", "Rodrigez", "12345678I", 123456789, new List<Paquete>(), new List<Paquete>());
            cliente2 = new Cliente("Zinedine", "Zidane", "87654321Q", 987654321, new List<Paquete>(), new List<Paquete>());
            cliente3 = new Cliente("Ronaldo", "Nazario", "14376286T", 836524816, new List<Paquete>(), new List<Paquete>());
            cliente4 = new Cliente("Andres", "Iniesta", "98354271O", 983277451, new List<Paquete>(), new List<Paquete>());
            cliente5 = new Cliente("Fernando", "Torres", "76243109E", 146372899, new List<Paquete>(), new List<Paquete>());

            Paquete paquete1 = new Paquete("producto1", "el mejor", 12,new DateTime(2008, 6, 1, 7, 47, 0), 9);
            Paquete paquete2 = new Paquete("producto2", "el casi mejor", 34, new DateTime(2016, 6, 1, 7, 47, 0), 8);
            Paquete paquete3 = new Paquete("producto3", "el intermedio", 6, new DateTime(2014, 6, 1, 7, 47, 0), 6);
            Paquete paquete4 = new Paquete("producto4", "el decente", 5, new DateTime(2021, 6, 1, 7, 47, 0), 5);
            Paquete paquete5 = new Paquete("producto5", "el peor", 3, new DateTime(2325, 6, 1, 7, 47, 0), 6);



            comprados.Add(paquete1);
            comprados.Add(paquete2);
            comprados.Add(paquete3);
            comprados.Add(paquete4);
            comprados.Add(paquete5);

            reservados.Add(paquete1);
            reservados.Add(paquete2);
            reservados.Add(paquete3);
            reservados.Add(paquete4);
            reservados.Add(paquete5);


            lb_principal.Items.Add(cliente1);
            lb_principal.Items.Add(cliente2);
            lb_principal.Items.Add(cliente3);
            lb_principal.Items.Add(cliente4);
            lb_principal.Items.Add(cliente5);

            cliente1.paquetes_comprados.AddRange(comprados);
            cliente1.paquetes_reservados.AddRange(reservados);

            cliente2.paquetes_comprados.AddRange(comprados);
            cliente2.paquetes_reservados.AddRange(reservados);

            cliente3.paquetes_comprados.AddRange(comprados);
            cliente3.paquetes_reservados.AddRange(reservados);

            cliente4.paquetes_comprados.AddRange(comprados);
            cliente4.paquetes_reservados.AddRange(reservados);

            cliente5.paquetes_comprados.AddRange(comprados);
            cliente5.paquetes_reservados.AddRange(reservados);

            
        }

        private void btn_principal_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (client == null)
            {
                MessageBox.Show("No ha introducido ningun cliente");
            }
            else
            {
                this.Hide();

                Form3 f2 = new Form3(client.paquetes_comprados, client.paquetes_reservados, this, client);

                f2.Show();
            }
        }
    }
}
