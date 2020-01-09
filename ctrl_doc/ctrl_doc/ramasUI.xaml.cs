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

namespace ctrl_doc
{
    /// <summary>
    /// Lógica de interacción para ramasUI.xaml
    /// </summary>
    public partial class ramasUI : UserControl
    {
        static string[] ramas = new string[]
        {
            "Quebalix 1 - MTTO",
            "Quebalix 2 - MTTO",
            "Quebalix 3 - MTTO",
            "Quebalix 4 - MTTO",
            "Quebalix-Generales  - MTTO",
            "Quebalix 1 - OP",
            "Quebalix 2 - OP",
            "Quebalix 3 - OP",
            "Quebalix 4 - OP",
            "Quebalix-Generales - OP",
            "Comunicaciones",
            "C. Herramientas",
            "U. Ligeras",
            "Oficinas"
        };

        DataTable dt = new DataTable();

        public ramasUI()
        {
            InitializeComponent();
            dt.Columns.Add("No");
            dt.Columns.Add("Ramas");
            int r = 1;
            foreach (var item in ramas)
            {
                DataRow dr = dt.NewRow();
                dr["No"] = r.ToString();
                dr["Ramas"] = item.ToString();
                dt.Rows.Add(dr);
                r++;
            }
            dgRamas.ItemsSource = dt.DefaultView;
        }

        private void DgRamas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgRamas.SelectedIndex >= 0)
            {
                MessageBox.Show(ramas[dgRamas.SelectedIndex]);
            }
        }
    }
}
