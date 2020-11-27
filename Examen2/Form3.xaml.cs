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
    /// Lógica de interacción para Form3.xaml
    /// </summary>
    public partial class Form3 : Window
    {


        public List<Paquete> comprados;
        public List<Paquete> reservados;
        public MainWindow main;
        public Cliente client;
        public Paquete paquete_comprado;
        public Paquete paquete_reservado;
        public static int cont = 0;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(List<Paquete> comprados, List<Paquete> reservados, MainWindow main, Cliente client)
        {
            InitializeComponent();
            this.comprados = comprados;
            this.reservados = reservados;
            this.main = main;
            this.client = client;
        }

        private void btn_comprar_Click(object sender, RoutedEventArgs e)
        {

            paquete_comprado = (Paquete)combo.SelectedItem;

            lb_terciario_comprados.Items.Add(paquete_comprado);
            combo.Items.Remove(paquete_comprado);

            client.ComprarPaquete(paquete_comprado);

            lb_terciario_comprados.Items.Refresh();
            combo.Items.Refresh();

        }

        private void btn_reservar_Click(object sender, RoutedEventArgs e)
        {

            paquete_reservado = (Paquete)combo.SelectedItem;

            lb_terciario_reservados.Items.Add(paquete_reservado);
            combo.Items.Remove(paquete_reservado);

            client.ReservarPaquete(paquete_reservado);

            lb_terciario_reservados.Items.Refresh();
            combo.Items.Refresh();

        }

        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {

            this.Hide();

            main.Show();
        }

        private void lb_terciario_comprados_Loaded(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < comprados.Count(); i++)
            {
                lb_terciario_comprados.Items.Add(comprados[i]);
            }

        }

        private void lb_terciario_reservados_Loaded(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < reservados.Count(); i++)
            {
                lb_terciario_reservados.Items.Add(reservados[i]);

            }
        }

        private void info_Loaded(object sender, RoutedEventArgs e)
        {
            info.Content = client.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void combo_Loaded(object sender, RoutedEventArgs e)
        {

            if (cont == 0)
            {

                Paquete paquete6 = new Paquete("producto6", "el mejor", 12, new DateTime(2008, 6, 1, 7, 47, 0), 9);
                Paquete paquete7 = new Paquete("producto7", "el casi mejor", 34, new DateTime(2016, 6, 1, 7, 47, 0), 8);
                Paquete paquete8 = new Paquete("producto8", "el intermedio", 6, new DateTime(2014, 6, 1, 7, 47, 0), 6);
                Paquete paquete9 = new Paquete("producto9", "el decente", 5, new DateTime(2021, 6, 1, 7, 47, 0), 5);
                Paquete paquete10 = new Paquete("producto10", "el peor", 3, new DateTime(2325, 6, 1, 7, 47, 0), 6);

                combo.Items.Add(paquete6);
                combo.Items.Add(paquete7);
                combo.Items.Add(paquete8);
                combo.Items.Add(paquete9);
                combo.Items.Add(paquete10);

                cont++;

            }
        }
    }
}
