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

namespace ctrl_doc
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            target.Children.Add(new buscar_doc());
        }

        private void Menu_buscar_doc_Click(object sender, RoutedEventArgs e)
        {
            target.Children.Clear();
            target.Children.Add(new buscar_doc());
        }

        private void Menu_ir_doc_Click(object sender, RoutedEventArgs e)
        {
            target.Children.Clear();
            target.Children.Add(new ramasUI());
        }

        private void Menu_cancelados_Click(object sender, RoutedEventArgs e)
        {
            target.Children.Clear();
            target.Children.Add(new canceladoUI());
        }

        private void Menu_registrar_Click(object sender, RoutedEventArgs e)
        {
            target.Children.Clear();
            target.Children.Add(new rdocumentoUI());
        }

        private void Menu_salir_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Menu_personal_Click(object sender, RoutedEventArgs e)
        {
            target.Children.Clear();
            target.Children.Add(new rpersonalUI());
        }
    }
}
