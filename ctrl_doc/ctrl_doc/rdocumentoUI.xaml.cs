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
    /// Lógica de interacción para rdocumentoUI.xaml
    /// </summary>
    public partial class rdocumentoUI : UserControl
    {
        datos r, c;
        public rdocumentoUI()
        {
            InitializeComponent();
            cargarcbx();
        }

        public rdocumentoUI(int c, string doc, string r, string car)
        {
            InitializeComponent();
            cargarcbx();
            txtCodigo.IsEnabled = false;
            txtNombreDoc.IsEnabled = false;
            txtCodigo.Text = c.ToString();
            txtNombreDoc.Text = doc;
            cbxRama.Text = r;
            cbxCarpeta.Text = car;
            lblTitulo.Content = "Editar documento";
        }

        public void cargarcbx()
        {
            r = new datos();
            c = new datos();

            fillcbx(cbxRama, r.ramas);
            fillcbx(cbxCarpeta, c.carpetas);
        }

        private void CbxResponsable_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        public void fillcbx(ComboBox cbx, string[] arreglo)
        {
            foreach (string item in arreglo)
            {
                cbx.Items.Add(item);
            }
        }
    }
}
