using FormesPessoaImove.Classes;
using FormesPessoaImove.Db;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FormesPessoaImove.ClassesDb
{
    public class PessoaDb
    {
        private Banco banco;
        public PessoaDb()
        {
            banco = new Banco();
        }
        public void Insert(Pessoa pessoa)
        {
            using (var conn = banco.GetConnection())
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO Pessoa (nome, endereco, email) " +
                   "VALUES (@nome, @endereco, @email)", conn))
                {
                    cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                    cmd.Parameters.AddWithValue("@email", pessoa.Email);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public List<Pessoa> SelectAll()
        {
            using (var conn = banco.GetConnection())
            {
                using (var cmd = new NpgsqlCommand("SELECT id, nome, endereco, email FROM Pessoa", conn))
                {
                    
                    using (var leitura = cmd.ExecuteReader())
                    {
                        List<Pessoa> listaPessoa = new List<Pessoa>();
                        while (leitura.Read())
                        {
                            int id = leitura.GetInt32(0);
                            string nome = leitura.GetString(1);
                            string endereco = leitura.GetString(2);
                            string email = leitura.GetString(3);
                            Pessoa pessoa = new Pessoa(id, nome, endereco, email);
                            listaPessoa.Add(pessoa);
                        }
                        return listaPessoa; 
                    }
                }
            }
        }

        public void Delete(Pessoa p)
        {
            using (var conn = banco.GetConnection())
            {
                using (var cmd = new NpgsqlCommand("Delete From pessoa WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", p.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            
        }
        public void Update(Pessoa pessoa)
        {
            using (var conn = banco.GetConnection())
            {
                using (var cmd = new NpgsqlCommand("UPDATE pessoa SET" +
                    " nome = @nome, endereco = @endereco, email = @email WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", pessoa.Id);
                    cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@endereco", pessoa.Endereco);
                    cmd.Parameters.AddWithValue("@email", pessoa.Email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Pessoa SelectObjetoId(int id)
        {
            using (var conn = banco.GetConnection())
            {
                using (var cmd = new NpgsqlCommand("SELECT id, nome, endereco, email FROM pessoa WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var leitura = cmd.ExecuteReader())
                    {
                        if (leitura.Read())
                        {
                            int pessoaId = leitura.GetInt32(0);
                            string nome = leitura.GetString(1);
                            string endereco = leitura.GetString(2);
                            string email = leitura.GetString(3);
                            return new Pessoa(pessoaId, nome, endereco, email);
                        }
                        else
                        {
                            // Retorna null se não encontrar uma pessoa com o ID especificado
                            return null;
                        }
                    }
                }
            }
        }


    }
}

