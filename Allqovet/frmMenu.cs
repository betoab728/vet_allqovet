using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allqovet
{
    public partial class frmMenu : Form
    {
        private Panel leftBorderBtn;

        private Form formActual;

        

        public frmMenu()
        {
          InitializeComponent();
            /*
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,41);
            panelmenu.Controls.Add(leftBorderBtn);*/

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  BotonActivo(btnVentas);

            MostrarSubmenu(panelSubmenuVentas);

        }

        private void BotonActivo(Button button)
        {

            foreach (Control item in panelmenu.Controls)
            {

              

                if (item is Button )
                {
                   

                    Button botonn = (Button)item;

                    botonn.TextAlign = ContentAlignment.MiddleCenter;
                    botonn.BackColor = Color.FromArgb(153, 128, 154);
                  //  botonn.SendToBack();

                }
          
            }

            if (button.TextAlign == ContentAlignment.MiddleCenter)
            {

                button.TextAlign = ContentAlignment.MiddleRight;
                button.BackColor = Color.FromArgb(144, 116, 140);
                leftBorderBtn.BackColor = Color.White;
                leftBorderBtn.Location = new Point(0, button.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
           
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            Ocultarsubmenu();
        }

        private void Diseniomenu()
        {
           
        }

        private void Ocultarsubmenu()
        {
            if (panelSubmenuVentas.Visible == true)
                panelSubmenuVentas.Visible = false;

            if (panelsubmenuMant.Visible == true)
                panelsubmenuMant.Visible = false;

            if (panelsunmenuAlmacen.Visible == true)
                panelsunmenuAlmacen.Visible = false;

            if (panelsubmenuPedidos.Visible == true)
                panelsubmenuPedidos.Visible = false;

            if (panelsubmenuFinanzas.Visible == true)
                panelsubmenuFinanzas.Visible = false;

            if (panelsubmenuFacturacion.Visible == true)
                panelsubmenuFacturacion.Visible = false;

            if (panelsubmenuSistemas.Visible == true)
                panelsubmenuSistemas.Visible = false;

            if (panelsubmenuClientes.Visible == true)
                panelsubmenuClientes.Visible = false;
        }

       private void MostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible==false)
            {
                Ocultarsubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }

           

        }

        private void button3_Click(object sender, EventArgs e)
        {

           // BotonActivo(button3);

            frmClientes clientes = new frmClientes();
            AbrirFormHijo(clientes);
        

        }

        private void AbrirFormHijo( Form frm)
        {
            formActual = frm;
            frm.TopLevel = false;
            //frm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(frm);
            panelEscritorio.Tag = frm;
            frm.BringToFront();
            frm.SetDesktopLocation( (panelEscritorio.Width - frm.Width)/2, (panelEscritorio.Height - frm.Height)/2);
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // BotonActivo(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
         //   BotonActivo(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //  BotonActivo(button6);
            MostrarSubmenu(panelsubmenuPedidos);
        }

        private void button9_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(" ¿Salir del Sistema?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelSubmenuConsultorio);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelsubmenuMant);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelsunmenuAlmacen);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MostrarSubmenu(panelsubmenuFinanzas);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            MostrarSubmenu(panelsubmenuFacturacion);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelsubmenuSistemas);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelsubmenuClientes);
        }
    }
}
