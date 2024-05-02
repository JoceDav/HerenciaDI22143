using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SUMAR_Click(object sender, EventArgs e)
        {
            //Voy a darle comportamiento a mi boton 
            //voy a utilizar mi clase hija sumar 
            Sumar sumar = new Sumar(); //Instancie, o hice un nuevo objeto sumar llamar al metodo de clase suma operar
            textBox3.Text = sumar.operar(int.Parse(textBox1.Text),int.Parse(textBox2.Text)).ToString();
        }
        private void RESTAR_Click(object sender, EventArgs e)
        {
            //Voy a darle comportamiento a mi boton 
            //voy a utilizar mi clase hija restar
            Restar restar = new Restar(); //Instancie, o hice un nuevo objeto restar llamar al metodo de clase resta operar
            textBox3.Text = restar.operar(int.Parse(textBox1.Text),int.Parse(textBox2.Text)).ToString();
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
                //Voy a darle comportamiento a mi boton 
                //voy a utilizar mi clase hija multiplicar 
                Multiplicar multiplicar = new Multiplicar(); //Instancie, o hice un nuevo objeto multiplicar llamar al metodo de clase multiplicar operar
                textBox3.Text = multiplicar.operar(int.Parse(textBox1.Text),int.Parse(textBox2.Text)).ToString();
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            //Voy a darle comportamiento a mi boton 
            //voy a utilizar mi clase hija multiplicar 
            dividir Dividiendo = new dividir(); //Instancie, o hice un nuevo objeto multiplicar llamar al metodo de clase multiplicar operar
            textBox3.Text = Dividiendo.Operar(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
    }
}
