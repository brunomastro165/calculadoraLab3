using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWF
{
    public partial class Form1 : Form
    {
        bool fristTime = true;
        
        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void agregarDigito(string numero)
        {
            if (EntradaDatos.Text.Equals("0") || fristTime)
            {
                Console.WriteLine(fristTime);
                EntradaDatos.Text = "";
                fristTime = false;
            }

            EntradaDatos.Text += numero;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Bigual_Click(object sender, EventArgs e)
        {
            fristTime = true;

            try
            {
                EntradaDatos.Text = prueba.ingreso(EntradaDatos.Text);
            }
            catch (Exception exception)
            {
                EntradaDatos.Text = "Operación inválida";
            }



        }

        private void Buno_Click(object sender, EventArgs e)
        {
            agregarDigito(Buno.Text);
        }

        private void Bdos_Click(object sender, EventArgs e)
        {
            agregarDigito(Bdos.Text);
        }

        private void Btres_Click(object sender, EventArgs e)
        {
            agregarDigito(Btres.Text);
        }

        private void Bcuatro_Click(object sender, EventArgs e)
        {
            agregarDigito(Bcuatro.Text);
        }

        private void Bcinco_Click(object sender, EventArgs e)
        {
            agregarDigito(Bcinco.Text);
        }

        private void Bseis_Click(object sender, EventArgs e)
        {
            agregarDigito(Bseis.Text);
        }

        private void Bsiete_Click(object sender, EventArgs e)
        {
            agregarDigito(Bsiete.Text);
        }

        private void Bocho_Click(object sender, EventArgs e)
        {
            agregarDigito(Bocho.Text);
        }

        private void Bnueve_Click(object sender, EventArgs e)
        {
            agregarDigito(Bnueve.Text);
        }

        private void Bcero_Click(object sender, EventArgs e)
        {
            agregarDigito(Bcero.Text);
        }

        private void Bpor_Click(object sender, EventArgs e)
        {
            agregarDigito(Bpor.Text);
        }

        private void Bdiv_Click(object sender, EventArgs e)
        {
            agregarDigito(Bdiv.Text);
        }

        private void Bmen_Click(object sender, EventArgs e)
        {
            agregarDigito(Bmen.Text);
        }

        private void Bmas_Click(object sender, EventArgs e)
        {
            agregarDigito(Bmas.Text);
        }

        private void BpA_Click(object sender, EventArgs e)
        {
            agregarDigito(BpA.Text);
        }

        private void BpC_Click(object sender, EventArgs e)
        {
            agregarDigito(BpC.Text);
        }

        private void Bborrar_Click(object sender, EventArgs e)
        {
            
            if (EntradaDatos.Text.Length > 0)
            {
                EntradaDatos.Text = EntradaDatos.Text.Remove(EntradaDatos.Text.Length-1);
            }
           
        }

        private void Bbtodo_Click(object sender, EventArgs e)
        {
            EntradaDatos.Text = "";
        }
    }
}