using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão "Inserir"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Carros.AddCar(new Carro(12, "00-11-22"));

            int ano;
            string matricula;

            ano = int.Parse(textBox1.Text);
            matricula = textBox2.Text;

            Carro aux = new Carro(ano, matricula);
            Carros.AddCar(aux);

            Carros.ShowPark();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
