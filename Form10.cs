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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();

            Modalidade md = new Modalidade();

            MySqlDataReader rr = md.consultarTodasModalidade01();
            while (rr.Read())
            {
                comboBox1.Items.Add(rr["descricaoModalidade"].ToString());
            }
            DAO_Conexao.con.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turma tu = new Turma(int.Parse(textBox1.Text.ToString()), comboBox2.Text, comboBox3.Text);


            if (tu.excluirTurma())
            {
                MessageBox.Show("Excluído com sucesso");
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();
            comboBox2.Text = "";

            int modalidade = -1;

            Modalidade md = new Modalidade(comboBox1.Text);

            try
            {
                MySqlDataReader r = md.consultarModalidade01();

                if (r.Read())
                {
                    modalidade = int.Parse(r["idEstudio_Modalidade"].ToString());
                    textBox1.Text = r["idEstudio_Modalidade"].ToString();

                    Turma turma = new Turma(modalidade);
                    DAO_Conexao.con.Close();

                    MySqlDataReader rt = turma.consultarTurma01();
                    while (rt.Read())
                    {
                        comboBox2.Items.Add(rt["diasemanaTurma"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            int modalidade = -1;

            Modalidade md = new Modalidade(comboBox1.Text);
            try
            {
                MySqlDataReader r = md.consultarModalidade01();
                if (r.Read())
                {
                    modalidade = int.Parse(r["idEstudio_Modalidade"].ToString());

                    Turma tu = new Turma(modalidade, comboBox2.Text);

                    DAO_Conexao.con.Close();
                    MySqlDataReader rt = tu.consultarTurmaDiaSemana();
                    while (rt.Read())
                    {
                        comboBox3.Items.Add(rt["horaTurma"].ToString());

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
    

