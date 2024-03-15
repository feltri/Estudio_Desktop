
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class Aluno
    {
        private string CPF;
        private string Nome;
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Complemento;
        private string CEP;
        private string Cidade;
        private string Estado;
        private string Telefone;
        private string Email;
        private byte[] Foto;
        private bool Ativo;

        public Aluno(string cpf, string nome, string rua, string numero, string bairro, string complemento, string cep, string cidade, string estado, string telefone, string email)
        {
            setCPF(cpf);
            setNome(nome);
            setRua(rua);
            setNumero(numero);
            setBairro(bairro);
            setComplemento(complemento);
            setCEP(cep);
            setCidade(cidade);
            setEstado(estado);
            setTelefone(telefone);
            setEmail(email);
            //setFoto(foto);
        }

        public Aluno()
        {
        }
        public Aluno(string cpf)
        {
            setCPF(cpf);
        }

        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }

        public string getCPF()
        {
            return this.CPF;
        }

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setRua(string Rua)
        {
            this.Rua = Rua;
        }

        public string getRua()
        {
            return this.Rua;
        }

        public void setNumero(string Numero)
        {
            this.Numero = Numero;
        }

        public string getNumero()
        {
            return this.Numero;
        }

        public void setBairro(string Bairro)
        {
            this.Bairro = Bairro;
        }

        public string getBairro()
        {
            return this.Bairro;
        }

        public void setComplemento(string Complemento)
        {
            this.Complemento = Complemento;
        }

        public string getComplemento()
        {
            return this.Complemento;
        }

        public void setCEP(string CEP)
        {
            this.CEP = CEP;
        }

        public string getCEP()
        {
            return this.CEP;
        }

        public void setCidade(string Cidade)
        {
            this.Cidade = Cidade;
        }

        public string getCidade()
        {
            return this.Cidade;
        }

        public void setEstado(string Estado)
        {
            this.Estado = Estado;
        }

        public string getEstado()
        {
            return this.Estado;
        }

        public void setTelefone(string Telefone)
        {
            this.Telefone = Telefone;
        }

        public string getTelefone()
        {
            return this.Telefone;
        }

        public void setEmail(string Email)
        {
            this.Email = Email;
        }

        public string getEmail()
        {
            return this.Email;
        }

        public void setFoto(byte[] Foto)
        {
            this.Foto = Foto;
        }

        public byte[] getFoto()
        {
            return this.Foto;
        }

        public void setAtivo(bool ativo)
        {
            this.Ativo = ativo;
        }

        public bool getAtivo()
        {
            return this.Ativo;
        }

        public bool cadastrarAluno()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_Aluno (CPFAluno, nomeAluno, ruaAluno, numeroAluno, bairroAluno, complementoAluno, CEPAluno, cidadeAluno, estadoAluno, telefoneAluno, emailAluno) values ('" + CPF + "','" + Nome + "','" + Rua + "','" + Numero + "','" + Bairro + "','" + Complemento + "','" + CEP + "','" + Cidade + "','" + Estado + "','" + Telefone + "','" + Email + "')", DAO_Conexao.con);

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

        public bool consultarAluno()
        {
            Boolean existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT  * FROM Estudio_Aluno   WHERE CPFAluno= '" + getCPF() + "'" , DAO_Conexao.con);
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
        }

       /* public bool excluirAluno()
         {
             Boolean existe = false;
             try
             {
                 DAO_Conexao.con.Open();
                 MySqlCommand consulta = new MySqlCommand("DELETE * FROM Estudio_Aluno   WHERE CPFAluno= '" + CPF + "'", DAO_Conexao.con);
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


       public bool excluirAluno()
        {
            bool exclui = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand update = new MySqlCommand("UPDATE Estudio_Aluno SET ativo=1 WHERE CPFAluno = '" + getCPF() + "'", DAO_Conexao.con);
                
                update.ExecuteNonQuery();
                exclui = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();

            }
            return exclui;
        }

        public MySqlDataReader consultarAluno01()
        {
            MySqlDataReader resultado = null;

            try
            {
                DAO_Conexao.con.Open();

                MySqlCommand consulta = new MySqlCommand("SELECT * FROM Estudio_Aluno where CPFAluno = '" + CPF + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return resultado;
        }
        public bool atualizarAluno()
        {
            bool updt = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand update = new MySqlCommand("UPDATE Estudio_Aluno SET nomeAluno= '" + Nome + "', ruaAluno='" + Rua + "', numeroALUNO='" + Numero + "', bairroAluno='" + Bairro + "', complementoAluno='" + Complemento + "',CEPAluno='" + CEP + "',cidadeAluno='" + Cidade + "',estadoAluno='" + Estado + "',telefoneAluno='" + Telefone + "'emailAluno='" + Email +"'fotoAluno='" + Foto, DAO_Conexao.con);

                update.ExecuteNonQuery();
                updt = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DAO_Conexao.con.Close();

            }
            return updt;
        }
    }
}