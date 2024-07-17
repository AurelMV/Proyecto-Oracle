using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion1
{
    public partial class FormularioPrincipal : Form
    {
        public static IconMenuItem MenuActivo = null;
        public static Form FormularioActivo = null;
        public FormularioPrincipal()
        {
            InitializeComponent();
        }


        private void AbrirForma(IconMenuItem menu, Form formulario)
        {

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();

            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iconSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menucursos_Click(object sender, EventArgs e)
        {
            AbrirForma((IconMenuItem)sender, new formingresar());



        }

        private void menuinscripcion_Click(object sender, EventArgs e)
        {
            AbrirForma((IconMenuItem)sender, new formGestionProveedores());
        }

        private void menudocentes_Click(object sender, EventArgs e)
        {
            AbrirForma((IconMenuItem)sender, new formDestionlibro
                ());
        }

        private void menuciclos_Click(object sender, EventArgs e)
        {
            AbrirForma((IconMenuItem)sender, new formGestionCategoria()); 
        }
    }
}
