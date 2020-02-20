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
using System.Data;

namespace ctrl_doc
{
    /// <summary>
    /// Lógica de interacción para documentos.xaml
    /// </summary>
    public partial class documentos : Window
    {
        string rama, carpeta;
        clsDB db = new clsDB();
        public documentos(string r, string c)
        {
            InitializeComponent();
            lblTitulo.Content = string.Format("{0}/{1}",r, c);
            datos d = new datos();
            rama = r;
            carpeta = c;
            dgDocumentos.ItemsSource = db.read(string.Format("verDocs '{0}','{1}'",r, c)).DefaultView;
        }

        public void populate(string[] arreglo, string t)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("No");
            dt.Columns.Add(t);
            int r = 1;
            foreach (var item in arreglo)
            {
                DataRow dr = dt.NewRow();
                dr["No"] = r.ToString();
                dr[t] = item.ToString();
                dt.Rows.Add(dr);
                r++;
            }
            dgDocumentos.ItemsSource = dt.DefaultView;
        }

        private void Menu_editar_Click(object sender, RoutedEventArgs e)
        {
            int si = dgDocumentos.SelectedIndex;
            if (si >= 0)
            {
                DataTable dt = new DataTable();
                dt = ((DataView)dgDocumentos.ItemsSource).ToTable();
                int id = Convert.ToInt32(dt.Rows[si][0]);
                string cod = dt.Rows[si][1].ToString();
                string doc = dt.Rows[si][2].ToString();
                blank b = new blank(new rdocumentoUI(id, cod, doc));
                b.ShowDialog();
            }
        }

        private void Menu_historial_Click(object sender, RoutedEventArgs e)
        {
            int si = dgDocumentos.SelectedIndex;
            if (si >= 0)
            {
                DataTable dt = new DataTable();
                dt = ((DataView)dgDocumentos.ItemsSource).ToTable();
                int cod = Convert.ToInt32(dt.Rows[si][0]);
                string doc = dt.Rows[si][1].ToString();
                historial h = new historial(cod, doc);
                h.ShowDialog();
            }
        }

        private void Menu_cancelar_Click(object sender, RoutedEventArgs e)
        {
            int si = dgDocumentos.SelectedIndex;
            if (si >= 0)
            {
                DataTable dt = new DataTable();
                dt = ((DataView)dgDocumentos.ItemsSource).ToTable();
                int cod = Convert.ToInt32(dt.Rows[si][0]);
                string doc = dt.Rows[si][1].ToString();
                cancelarDoc cd = new cancelarDoc(cod, doc);
                cd.ShowDialog();
            }
        }

        private void Menu_habilitar_Click(object sender, RoutedEventArgs e)
        {
            int si = dgDocumentos.SelectedIndex;
            if (si >= 0)
            {
                DataTable dt = new DataTable();
                dt = ((DataView)dgDocumentos.ItemsSource).ToTable();
                int cod = Convert.ToInt32(dt.Rows[si][0]);
                string doc = dt.Rows[si][1].ToString();
                habilitarDoc cd = new habilitarDoc(cod, doc);
                cd.ShowDialog();
            }
        }
    }
}
