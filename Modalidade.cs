using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Modalidade
    {
        private string Descricao;
        private float Preco;
        private int qtde_alunos, qtde_aulas;

        public Modalidade()
        {
        }

        public Modalidade(string descricao)
        {
            Descricao = descricao;
        }

        public Modalidade(string descricao, float preco, int qtde_alunos, int qtde_aulas)
        {
            Descricao = descricao;
            Preco = preco;
            this.qtde_alunos = qtde_alunos;
            this.qtde_aulas = qtde_aulas;
        }

        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public float Preco1 { get => Preco; set => Preco = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }
        public int Qtde_alunos { get => qtde_alunos; set => qtde_alunos = value; }

        public bool cadastrarModelidade()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Modalidade (descricaoModalidade, precoModalidade, qtdeAlunos, qtdeAulas) values" + "('" + Descricao + "','" + Preco + "','" + qtde_alunos + "','" + qtde_aulas + "')", DAO_Conexao.con);

                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        /*public bool consultarModelidade()
        {
            Boolean existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT  * FROM Estudio_Modelidade   WHERE descricaoModelidade= '" + Descricao1 + "'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();

            }
            return existe;
        }*/

        public MySqlDataReader consultarModalidade01()
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade where descricaoModalidade = '" + Descricao1 + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                //DAO_Conexao.con.Close();
            }
            return resultado;
        }

        public MySqlDataReader consultarTodasModalidade01()
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Modalidade WHERE ativa=0 ", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                //DAO_Conexao.con.Close();
            }
            return resultado;
        }

        public bool excluirModalidade()
        {
            bool exclui = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand update = new MySqlCommand("UPDATE Estudio_Modalidade SET ativa=1 WHERE descricaoModalidade = '" + Descricao1 + "'", DAO_Conexao.con);

                update.ExecuteNonQuery();
                exclui = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close(); 

            }
            return exclui;
        }

        /* public bool excluirModelidade()
         {
             Boolean existe = false;
             try
             {
                 DAO_Conexao.con.Open();
                 MySqlCommand consulta = new MySqlCommand("DELETE * FROM Estudio_Modelidade   WHERE descricaoModelidade= '" + Descricao1 + "'", DAO_Conexao.con);
                 MySqlDataReader resultado = consulta.ExecuteReader();
                 if (resultado.Read())
                 {
                     existe = true;
                 }
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.ToString());
             }
             finally
             {
                 DAO_Conexao.con.Close();

             }
             return existe;
         }*/

        public bool atualizarModelidade()
        {
            bool updt = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand update = new MySqlCommand("UPDATE Estudio_Modalidade SET descricaoModalidade='" + Descricao + "', precoModalidade=" + Preco + ",qtdeAlunos=" + Qtde_alunos + ",qtdeAulas=" + Qtde_aulas + " WHERE descricaoModalidade='" + Descricao1 + "'", DAO_Conexao.con);
                update.ExecuteNonQuery();
                updt = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();

            }
            return updt;
        }
    }
}

