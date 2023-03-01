using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAP_Intro
{
    public partial class ThirdForm : Form
    {
        public ThirdForm()
        {
            InitializeComponent();
        }

        private void btnClickMe_MouseMove(object sender, MouseEventArgs e)
        {
            //Generar números aleatorios
            Random randomX = new Random();
            Random randomY = new Random();
            int coordenadaX, coordenadaY;
            //Asignamos valores a las variables
            coordenadaX = randomX.Next(0, ClientSize.Width);
            coordenadaY = randomY.Next(0, ClientSize.Height);

            //Mover el boton
            btnClickMe.Location = new Point(coordenadaX, coordenadaY);


        }
    }
}
