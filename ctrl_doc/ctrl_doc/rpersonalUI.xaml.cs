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
    /// Lógica de interacción para rpersonalUI.xaml
    /// </summary>
    public partial class rpersonalUI : UserControl
    {
        clsDB db = new clsDB();
        public rpersonalUI()
        {
            InitializeComponent();

            fill(cbxPuesto, db.read("select puestos.puesto from puestos"));
            fill(cbxArea, db.read("select arearps.arearp from arearps"));
            fill(cbxOM, db.read("select mos.mo from mos"));
        }

        public void fill(ComboBox cbx, DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbx.Items.Add(dt.Rows[i][0]);
            }
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string cmd = string.Format("regPers '{0}','{1}','{2}','{3}'", txtName.Text, cbxPuesto.Text, cbxOM.Text, cbxArea.Text);
                db.write(cmd);
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }
    }
}
