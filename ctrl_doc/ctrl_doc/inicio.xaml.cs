using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Lógica de interacción para inicio.xaml
    /// </summary>
    public partial class inicio : Window
    {
        clsDB db = new clsDB();
        BackgroundWorker bgw = new BackgroundWorker();
        public inicio()
        {
            InitializeComponent();
            bgw.DoWork += Bgw_DoWork;
            bgw.RunWorkerCompleted += Bgw_RunWorkerCompleted;

            bgw.RunWorkerAsync();
        }

        private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(db.read("validarDatos").Rows[0][0].ToString());
                if (a < 1)
                {
                    db.write("regArearp");
                    db.write("regCarpetas");
                    db.write("regMos");
                    db.write("regPuestos");
                    db.write("regRamas");
                }
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
            
        }
    }
}
