using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Turma
    {
        private String professor, dia_semana, hora;
        private int modalidade;

        public int Modalidade { get => modalidade; set => modalidade = value; }
        public string Professor { get => professor; set => professor = value; }
        public string Dia_semana { get => dia_semana; set => dia_semana = value; }
        public string Hora { get => hora; set => hora = value; }

        public Turma(int modalidade, string professor, string dia_semana, string hora)
        {
            this.professor = professor;
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
        }

        public Turma(int modalidade, string dia_semana, string hora)
        {
           
            this.dia_semana = dia_semana;
            this.hora = hora;
            this.modalidade = modalidade;
        }

        public Turma(int modalidade)
        {
            this.modalidade = modalidade;
        }

        public Turma(int modalidade, string dia_semana)
        {
            this.dia_semana = dia_semana;
            this.modalidade = modalidade;
        }

        public Turma()
        {
        }

        public bool cadastrarTurma()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand( "insert into Estudio_Turma (idModalidade, professorTurma, diasemanaTurma, horaTurma) values (" + modalidade + ",'" + professor + "','" + dia_semana + "','" + hora + "')", DAO_Conexao.con);

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

        public bool excluirTurma()
        {
            bool exclui = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand update = new MySqlCommand("DELETE FROM Estudio_Turma WHERE idModalidade = '" + modalidade + "' AND diasemanaTurma = '" +dia_semana+ "' AND horaTurma = '" + hora + "'", DAO_Conexao.con);

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

        public MySqlDataReader consultarTurma01()
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE idModalidade = " + modalidade + "", DAO_Conexao.con);
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

        public MySqlDataReader consultarTurmaDiaSemana()
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma WHERE idModalidade = " + modalidade + " AND diasemanaTurma ='" + dia_semana + "'", DAO_Conexao.con);
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
        /* public MySqlDataReader consultarTurma()
         {
             MySqlDataReader resultado = null;

             try
             {
                 DAO_Conexao.con.Open();

                 MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Turma where dia_semana = '" + Dia_semana + "'", DAO_Conexao.con);
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
         }*/
    }
}
