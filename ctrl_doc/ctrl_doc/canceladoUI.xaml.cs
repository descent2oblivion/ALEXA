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
using System.Data;

namespace ctrl_doc
{
    /// <summary>
    /// Lógica de interacción para canceladoUI.xaml
    /// </summary>
    public partial class canceladoUI : UserControl
    {
        public canceladoUI()
        {
            InitializeComponent();
            datos d = new datos();
            populate(d.areas, "areas");
        }

        public void populate(string[] arreglo, string t)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("No");
            dt.Columns.Add(t);
            dt.Columns.Add("Activo");
            int r = 1;
            foreach (var item in arreglo)
            {
                DataRow dr = dt.NewRow();
                dr["No"] = r.ToString();
                dr[t] = item.ToString();
                dr["Activo"] = "SI";
                dt.Rows.Add(dr);
                r++;
            }
            dgDocumentos.ItemsSource = dt.DefaultView;
        }
    }
}
