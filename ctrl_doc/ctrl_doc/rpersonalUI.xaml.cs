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
    /// Lógica de interacción para rpersonalUI.xaml
    /// </summary>
    public partial class rpersonalUI : UserControl
    {
        datos p, m, a;
        public rpersonalUI()
        {
            InitializeComponent();
            p = new datos();
            m = new datos();
            a = new datos();

            fillcbx(cbxPuesto, p.puestos);
            fillcbx(cbxOM, m.mo);
            fillcbx(cbxArea, a.areas);
        }

        public void fillcbx(ComboBox cbx, string [] arreglo)
        {
            foreach (string item in arreglo)
            {
                cbx.Items.Add(item);
            }
        }
    }
}
