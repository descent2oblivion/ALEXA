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
    /// Lógica de interacción para rdocumentoUI.xaml
    /// </summary>
    public partial class rdocumentoUI : UserControl
    {
        clsDB db = new clsDB();
        public rdocumentoUI()
        {
            InitializeComponent();
            rno.IsChecked = true;
            rno.IsEnabled = false;
            rsi.IsEnabled = false;
            load_cbx();
            dgrev.ItemsSource = db.read(string.Format("verRevs {0}", -1)).DefaultView;
        }

        static int codAct = 0;
        public rdocumentoUI(int c, string codi, string nom)
        {
            InitializeComponent();
            load_cbx();
            rsi.IsChecked = true;
            rno.IsEnabled = false;
            rsi.IsEnabled = false;
            txtCodigo.IsEnabled = false;
            txtNombreDoc.IsEnabled = false;

            DataTable dt = new DataTable();
            dt = db.read(string.Format("verDoc {0}", c));

            txtCodigo.Text = dt.Rows[0][1].ToString();
            txtNombreDoc.Text = dt.Rows[0][2].ToString();
            cbxResponsable.Text = dt.Rows[0][3].ToString();
            cbxRama.Text = dt.Rows[0][6].ToString();
            cbxCarpeta.Text = dt.Rows[0][7].ToString();
            lblTitulo.Content = "Editar documento";
            codAct = c;
            dgrev.ItemsSource = db.read(string.Format("verRevs {0}", codAct)).DefaultView;
        }

        public void load_cbx()
        {
            fill(cbxResponsable, db.read("select personales.nombre from personales"));
            fill(cbxCarpeta, db.read("select carpetas.carpeta from carpetas"));
            fill(cbxRama, db.read("select ramas.rama from ramas"));
        }
        public void fill(ComboBox cbx, DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbx.Items.Add(dt.Rows[i][0]);
            }
        }


        private void CbxResponsable_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            if (txtCodigo.IsEnabled)
            {
                try
                {
                    //[regDoc '004', 'reporte 6', 'Dina Michelle', 'Creacion del reporte 6', 'Emmanuel C.', 'Quebalix 1 - MTTO', 'Formatos'
                    string cmd = string.Format("regDoc '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'", txtCodigo.Text, txtNombreDoc.Text, cbxResponsable.Text, txtComentarios.Text, txtAut.Text, cbxRama.Text, cbxCarpeta.Text);
                    db.write(cmd);
                    MessageBox.Show("Registro exitoso");
                }
                catch (Exception z)
                {
                    MessageBox.Show("El registro no se pudo completar, favor de verificar campos");
                }
            }
            else
            {
                try
                {
                    MessageBoxResult mbr = MessageBox.Show("Confirmar actualizacion","",MessageBoxButton.YesNo);
                    if (mbr == MessageBoxResult.Yes)
                    {
                        //[regDoc '004', 'reporte 6', 'Dina Michelle', 'Creacion del reporte 6', 'Emmanuel C.', 'Quebalix 1 - MTTO', 'Formatos'
                        string cmd = string.Format("actDoc {7}, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'", txtCodigo.Text, txtNombreDoc.Text, cbxResponsable.Text, txtComentarios.Text, txtAut.Text, cbxRama.Text, cbxCarpeta.Text, codAct);
                        db.write(cmd);
                        MessageBox.Show("Actualizacion exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Operacion cancelada");
                    }
                }
                catch (Exception z)
                {
                    MessageBox.Show("El registro no se pudo completar, favor de verificar campos");
                }
            }
        }
    }
}
