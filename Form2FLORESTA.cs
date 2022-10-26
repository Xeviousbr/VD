using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jornada_ao_Desconhecido
{
    public partial class Form2FLORESTA : Form
    {
        public Form2FLORESTA()
        {
            InitializeComponent();
        }

        private void Form2FLORESTA_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }

        private void timerIN_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                timerIN.Stop();
                timerOUT.Start();
            }
            else
            {
                this.Opacity = this.Opacity + 0.01;
            }
        }

        private void timerOUT_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {

                timerOUT.Stop();
                this.Dispose();
                Form3INICIO f3Inicio = new Form3INICIO();
                f3Inicio.Show();

             }
            else
            { 

                this.Opacity = this.Opacity - 0.01;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}