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
using System.Windows.Shapes;

namespace Examen2
{
    /// <summary>
    /// Lógica de interacción para Form2.xaml
    /// </summary>
    public partial class Form2 : Window
    {
        public List<Paquete> comprados;
        public List<Paquete> reservados;
        public MainWindow main;
        public Paquete package;
        public Paquete package1;
        public Cliente client;


        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<Paquete> comprados, List<Paquete> reservados, MainWindow main,Cliente client)
        {
            InitializeComponent();
            this.comprados = comprados;
            this.reservados = reservados;
            this.main = main;
            this.client = client;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < comprados.Count(); i++)
            {
                lb_secundario.Items.Add(comprados[i]);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();

            main.Show();

        }

        private void lb_secundario_Copy_Loaded(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < reservados.Count(); i++)
            {
                lb_secundario_Copy.Items.Add(reservados[i]);
            }

        }

        private void btn_eliminar_Click(object sender, RoutedEventArgs e)
        { 

            package = (Paquete)lb_secundario.SelectedItem;
            package1 = (Paquete)lb_secundario_Copy.SelectedItem;

           

           // if ((package.fecha_ini.Ticks - package.duracion) >= 0)
            //{
                lb_secundario.Items.Remove(package);
                client.paquetes_comprados.Remove(package);

                lb_secundario.Items.Refresh();
                lb_secundario_Copy.Items.Refresh();
           // }
           // else if ((package.fecha_ini.Ticks - package.duracion) >= 0 )
           // {

            lb_secundario_Copy.Items.Remove(package1);
            client.paquetes_reservados.Remove(package1);

            lb_secundario.Items.Refresh();
            lb_secundario_Copy.Items.Refresh();

            //}
            //else
            //{
            //       MessageBox.Show("Fecha caducada");
            //}



        }
    }
}

