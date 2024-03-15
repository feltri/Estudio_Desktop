using MySql.Data.MySqlClient;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
          /*   WindowState = FormWindowState.Maximized;
             //--------------------------------------
             Modalidade con_mod = new Modalidade();
             MySqlDataReader r = con_mod.consultarTodasModalidade01();
             while (r.Read())
                 dataGridView1.Rows.Add(r["descricaoModalidade"].ToString());
             DAO_Conexao.con.Close();*/
             //-----------------------------------------------
           Modalidade modalidade = new Modalidade();
            MySqlDataReader r = modalidade.consultarTodasModalidade01();
            while (r.Read())
            {
                comboBox1.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma(int.Parse(textBox5.Text), textBox2.Text, textBox3.Text, textBox4.Text);

            if (turma.cadastrarTurma())
            {
                MessageBox.Show("Cadastro Realizado com Sucesso");
            }
            else
                MessageBox.Show("Erro no Cadastro");
            
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(comboBox1.Text);
            
            MySqlDataReader r = modalidade.consultarModalidade01();

            /*if(r != null)
            {
                if(comboBox1.Text != "")
                {
                    if (r.Read())
                    {
                        textBox5.Text = r["idEstudio_Modalidade"].ToString();
                    }

                }
            }*/
            while (r.Read())
            {
                textBox5.Text = (r["idEstudio_Modalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }
    }
}
