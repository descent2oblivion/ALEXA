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
    /// Lógica de interacción para buscar_doc.xaml
    /// </summary>
    public partial class buscar_doc : UserControl
    {
        clsDB db = new clsDB();
        public buscar_doc()
        {
            InitializeComponent();
            radio_name.IsChecked = true;
        }

        private void txtSearchDoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (radio_code.IsChecked == true)
                {
                    DataTable dt = new DataTable();
                    dt = db.read(string.Format("buscarCodigo '{0}'", txtSearchDoc.Text));


                    int aidi = 0;
                    string cod = "";
                    string doc = "";
                    try
                    {
                        aidi = Convert.ToInt32(dt.Rows[0][0]);
                        cod = "";
                        doc = "";

                        blank b = new blank(new rdocumentoUI(aidi, cod, doc));
                        b.ShowDialog();
                    }
                    catch (Exception z)
                    {
                        MessageBox.Show("Documento no encontrado, favor de verificar el codigo");
                    }
                }

                if (radio_name.IsChecked == true)
                {
                    DataTable dt = new DataTable();
                    dt = db.read(string.Format("buscarNombre '{0}'", txtSearchDoc.Text));

                    try
                    {
                        int aidi = Convert.ToInt32(dt.Rows[0][0]);
                        string cod = "";
                        string doc = "";
                        blank b = new blank(new rdocumentoUI(aidi, cod, doc));
                        b.ShowDialog();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Documento no encontrado, favor de verificar el nombre");
                    }
                    
                }
            }
        }
    }
}
