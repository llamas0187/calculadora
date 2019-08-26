using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (textuser.Text == "juancho")
            {
                if (textcontra.Text == "123tamarindo")
                    MessageBox.Show("Bienvenido juancho");
                else
                    MessageBox.Show("Contraseña es incorrecta");
            }
            else
                MessageBox.Show("Nombre de usuario incorrecto");
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
