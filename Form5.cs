using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modalidade modelidade= new Modalidade(textBox1.Text, float.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            if (modelidade.cadastrarModelidade())
                MessageBox.Show("Cadastro realizado com sucesso");
            else
                MessageBox.Show("Erro no cadastro");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

