using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllqovetBLL;

namespace Allqovet
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

       private void ListarAccesos()
        {
            try
            {
                NivelaccesoBLL nivel = new NivelaccesoBLL();

                cboAcceso.ValueMember = "Idnivel";
                cboAcceso.DisplayMember = "descripcion";
                cboAcceso.DataSource = nivel.Listar();   

            }

            catch (Exception)
            {

                throw;
            }

         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ListarAccesos();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            int x1 = textBox3.Left;
            int y1 = textBox3.Top + textBox3.Height;
            int x2 = textBox3.Right;
            int y2 = y1;

            // Crear un objeto Graphics a partir del formulario
            Graphics g = CreateGraphics();

            // Dibujar la línea debajo del TextBox
            g.DrawLine(Pens.Red, x1, y1, x2, y2);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
