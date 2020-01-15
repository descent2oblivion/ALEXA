using System;
using System.Collections.Generic;
using System.Data;
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
using ctrl_doc.Properties;

namespace ctrl_doc
{
    /// <summary>
    /// Lógica de interacción para ramasUI.xaml
    /// </summary>
    public partial class ramasUI : UserControl
    {
        static string[] ramas = new datos().ramas;

        public void populate (string [] arreglo, string t)
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
            dgRamas.ItemsSource = dt.DefaultView;
        }

        public ramasUI()
        {
            InitializeComponent();
            populate(ramas,"Ramas");
        }

        private void DgRamas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int si = dgRamas.SelectedIndex;
            string rama = "";
            string carpeta = "";
            if (si >= 0)
            {
                try
                {
                    if (lblTitulo.Content.ToString() == "Ramas")
                    {
                        DataTable dei = new DataTable();
                        dei = ((DataView)dgRamas.ItemsSource).ToTable();
                        string val = dei.Rows[si][1].ToString();
                        lblTitulo.Content = val;
                        datos d = new datos();
                        populate(d.carpetas, "Carpetas");
                    }
                    else
                    {
                        rama = lblTitulo.Content.ToString();
                        DataTable dei = new DataTable();
                        dei = ((DataView)dgRamas.ItemsSource).ToTable();
                        carpeta = dei.Rows[si][1].ToString();
                        documentos d = new documentos(rama, carpeta);
                        d.ShowDialog();
                    }
                }
                catch (Exception z)
                {
                    MessageBox.Show(z.Message);
                }
            }
        }
    }
}
