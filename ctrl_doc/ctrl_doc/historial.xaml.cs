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

namespace ctrl_doc
{
    /// <summary>
    /// Lógica de interacción para historial.xaml
    /// </summary>
    public partial class historial : Window
    {
        clsDB db = new clsDB();
        public historial(int id, string dok)
        {
            InitializeComponent();
            lblTitulo.Content = string.Format("Historial de: \n{0}", dok);
            dgDocumentos.ItemsSource = db.read(string.Format("verHist {0}", id)).DefaultView;
        }
    }
}
