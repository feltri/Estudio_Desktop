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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (DAO_Conexao.getConexao("143.106.241.3", "cl201098", "cl201098", "cl*06072005"))
            {
                Console.WriteLine("Conectado");
            }
            else
                Console.WriteLine("Erro de conexão");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(textBox1.Text, textBox2.Text);
            if (tipo == 0)
                MessageBox.Show("Usuário/Senha inválidos");
            if (tipo == 1)
            {
                MessageBox.Show("Usuário ADM");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
            }
            if (tipo == 2)
            {
                MessageBox.Show("Usuário Restrito");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                cadastrarLoginToolStripMenuItem.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form3>().Count() == 0)
            {
                Form3 f3 = new Form3();
                f3.MdiParent = this;
                f3.Show();
            }
        }

        private void cadastrarLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() == 0)
            {
                Form2 f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form4>().Count() == 0)
            {
                Form4 f4 = new Form4();
                f4.MdiParent = this;
                f4.Show();
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarModelidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form5>().Count() == 0)
            {
                Form5 f5 = new Form5();
                f5.MdiParent = this;
                f5.Show();
            }
        }

        private void consultarModelidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form8>().Count() == 0)
            {
                Form8 f8 = new Form8();
                f8.MdiParent = this;
                f8.Show();
            }

        }

        private void atualizarModelidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form7>().Count() == 0)
            {
                Form7 f7 = new Form7();
                f7.MdiParent = this;
                f7.Show();
            }



        }

        private void excluirModelidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form6>().Count() == 0)
            {
                Form6 f6 = new Form6();
                f6.MdiParent = this;
                f6.Show();
            }
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form9>().Count() == 0)
            {
                Form9 f9 = new Form9();
                f9.MdiParent = this;
                f9.Show();
            }
        }

        private void excluirTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form10>().Count() == 0)
            {
                Form10 f10 = new Form10();
                f10.MdiParent = this;
                f10.Show();
            }
        }



    }
}

   

       

        
    

