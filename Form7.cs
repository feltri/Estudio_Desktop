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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Modalidade modalidade = new Modalidade();
            MySqlDataReader r = modalidade.consultarTodasModalidade01();
            while (r.Read())
            {
                comboBox1.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Modalidade md = new Modalidade(comboBox1.Text, float.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            if(md.atualizarModelidade())
            MessageBox.Show("Atualizado com Sucesso");
            else
                MessageBox.Show("Erro ao Atualizar");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* Modalidade modalidade = new Modalidade(comboBox1.Text);
            MySqlDataReader r = modalidade.consultarModalidade01();
            while (r.Read())
            {
                textBox2.Text = (r["precoModalidade"].ToString());
                textBox3.Text = (r["qtdeAlunos"].ToString());
                textBox4.Text = (r["qtdeAulas"].ToString());
            }
            DAO_Conexao.con.Close();*/
        }
    }
}
