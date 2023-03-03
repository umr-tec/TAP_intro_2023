using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TAP_Intro
{
    public partial class SecondForm : Form
    {
        private bool colores;
        Point puntoXY;

        public SecondForm()
        {
            InitializeComponent();
            colores = true;
            this.Icon = Properties.Resources.tecsanpedro_solo;
        }

        private void SecondForm_Click(object sender, EventArgs e)
        {
            //Deshabilitar un evento
            this.MouseMove += new MouseEventHandler(this.SecondForm_MouseMove); 
        }

        private void SecondForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("No puedes cerrar el formulario, usa el CheckBox");
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            while (colores)
            {
                for (int i = 0; i < 254; i++)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);
                    Application.DoEvents();
                    Thread.Sleep(8);
                }
                for (int i = 254; i >= 0; i--)
                {
                    this.BackColor = Color.FromArgb(i, 255 - i, i);
                    Application.DoEvents();
                    Thread.Sleep(8);
                }
            }            
        }

        private void SecondForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                colores = false;
                MessageBox.Show("Presionaste la tecla S");
            }
        }

        private void SecondForm_MouseMove(object sender, MouseEventArgs e)
        {
            puntoXY = e.Location;
            pbImagen.Left = puntoXY.X;
            pbImagen.Top = puntoXY.Y;
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {
            //Deshabilitar un evento
            this.MouseMove -= this.SecondForm_MouseMove;
        }
    }
}
