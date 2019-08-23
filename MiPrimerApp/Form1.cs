using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerApp
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("Bienvenidos a C#");
        }

        private void Frm1_FormClosed(object sender, FormClosedEventArgs e)
        {
           // MessageBox.Show("Chau Chau . . .");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Se presionó el botón Izquierdo", "Jojo!");
            if (click.Button == MouseButtons.Right)
                MessageBox.Show("Se presionó el botón Derecho", "Jeje");
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Se presionó el botón del medio", "Pervertido!");
                */
                if(Txt_Prueba1.Text== "")
            {
                Txt_Prueba1.BackColor = Color.Aquamarine;
            }
            else
            {
                Txt_Prueba1.BackColor = System.Drawing.SystemColors.Control;
            }

        }
    }
    }

