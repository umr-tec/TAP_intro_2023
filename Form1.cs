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
        ThirdForm thirdForm = new ThirdForm();
        public frmInicio()
        {
            InitializeComponent();
         
            //Agregar un icono al Form
            this.Icon = Properties.Resources.tecsanpedro_solo;
            //Agregar Controles 
            TextBox txt1 = new TextBox();
            Button btn1 = new Button();

            //Catracteeristivcas a los controles 
            txt1.Name = "txtTexto1";
            txt1.Width = 130;
            txt1.Height = 40;
            txt1.Text = "Ingresa valor";
            txt1.Multiline = true;
            txt1.Location = new Point(300, 20);
            //
            btn1.Name = "btnEnviarValores";
            btn1.Width = 80;
            btn1.Height = 40;
            btn1.Text = "Enviar";
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Location = new Point(350, 60);
            this.Controls.Add(txt1);
            this.Controls.Add(btn1);
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
            if (cbTwoForms.Checked == true)
            {
                thirdForm.Show();
            }
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
