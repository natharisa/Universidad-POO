using BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_POO
{
    public partial class Form1 : Form
    {
        public Automovil movil = new Automovil();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEncender_Click(object sender, EventArgs e)
        {
            movil.Encender();
            label1.Text = "Encendido!";

        }

        private void BtnCargarCombu_Click(object sender, EventArgs e)
        {

            
            if (numericCombustible.Value>0)
            {
                movil.CargarCombustible((int)numericCombustible.Value);

            }
            else
            {
                
               movil.CargarCombustible();

            }


            progressBar1.Value = movil.Combustible;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            progressBar1.Value = movil.Combustible;

        }

        private void BtnAvanzar_Click(object sender, EventArgs e)
        {
            movil.Avanzar();
            progressBar1.Value = movil.Combustible;
        }

        private void BtnApagar_Click(object sender, EventArgs e)
        {
            movil.Apagar();
            label1.Text = "Apagado";

        }
    }
}
