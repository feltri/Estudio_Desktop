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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            Modalidade modalidade = new Modalidade();
            MySqlDataReader r =modalidade.consultarTodasModalidade01();
            while (r.Read())
            {
                comboBox1.Items.Add(r["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();
           // MySqlDataReader y = modalidade.consultarTodasModalidade01();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade(comboBox1.Text);

            if (comboBox1.Text != "")
            {
                if(modalidade.excluirModalidade())
                {
                    MessageBox.Show("Modalidade Excluída");
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
