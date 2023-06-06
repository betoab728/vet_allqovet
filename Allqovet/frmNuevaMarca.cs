using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using AllqovetBLL;


namespace Allqovet
{
    public partial class frmNuevaMarca : Form
    {
        public frmNuevaMarca()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Registrar() > 0)
            {
                MessageBox.Show("Marca Registrada");
            }

        }

        private int  Registrar()
        {
            Marca marca = new Marca();
            marca.Nombre = txtNombre.Text;

            int r = 0;

            using (MarcaBLL db= new MarcaBLL())
            {
                try
                {
                   r = db.Agregar(marca);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    r = 0;
                   
                }
            }
            return r;
        }
    }
}
