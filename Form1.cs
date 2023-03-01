using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
namespace TAP_Intro
{
    public partial class frmInicio : Form
    {
        //Objetos de entonro global
        SecondForm secondForm = new SecondForm();
        public frmInicio()
        {
            InitializeComponent();
            //Modificar el tamaño de la forma
            Thread nweq = new Thread(new ThreadStart(hilop));
        }
        public void hilop() {
            this.WindowState = FormWindowState.Normal;
            Thread.Sleep(4000);
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmInicio_DoubleClick(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Red;
            this.BackColor = Color.Red;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }        

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
          //  e.Graphics.FillEllipse(Brushes.Red, 10, 10, 100, 100);
        }

        private void frmInicio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");           
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿Deseas cambiar el color de fondo?","TAP Intro", MessageBoxButtons.YesNo, MessageBoxIcon.Question  );
            if (result == DialogResult.Yes)
            {
                //Cambiar el color del form de manera dinamica
                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                this.BackColor = colorDialog.Color;
            }
        }

        private void gbBorder_Enter(object sender, EventArgs e)
        {

        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void rdNone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNone.Checked == true)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
        }

        private void rdSizable_CheckedChanged(object sender, EventArgs e)
        {
            if (rdSizable.Checked == true)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void rbFixedD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFixedD.Checked == true)
            {
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
            }
        }

        private void btnColor_Click_1(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿Deseas cambiar el color de fondo?", "TAP Intro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Cambiar el color del form de manera dinamica
                ColorDialog colorDialog = new ColorDialog();
                colorDialog.ShowDialog();
                this.BackColor = colorDialog.Color;
            }
        }

        private void cbTwoForms_CheckedChanged(object sender, EventArgs e)
        {            
                        
        }

        private void cbOneForm_CheckedChanged(object sender, EventArgs e)
        {
            //Instanciar un nuevo formulario
            
            if (cbOneForm.Checked == true)
            {
                secondForm.Show();
            }
            else
            {
                secondForm.Hide();
            }
        }
    }
}
