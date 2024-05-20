using FormesPessoaImove.Classes;
using FormesPessoaImove.Db;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormesPessoaImove.ClassesDb
{
    public class ImovelDb
    {
        private Banco banco;

        public ImovelDb()
        {
            banco = new Banco();
        }


        public void Insert(Imovel imovel)
        {
            using (var conn = banco.GetConnection())
            {
                using (var cmd = new NpgsqlCommand("INSERT INTO imovel (endereco,quartos,garagens,aluguel,pessoaid) " +
                   "VALUES (@endereco, @quarto, @garagens, @aluguel, @pessoaid)", conn))
                {
                    cmd.Parameters.AddWithValue("@endereco", imovel.Endereco);
                    cmd.Parameters.AddWithValue("@quarto", imovel.Quartos);
                    cmd.Parameters.AddWithValue("@garagens", imovel.Garagens);
                    cmd.Parameters.AddWithValue("@aluguel", imovel.Aluguel);

                    // Verifica se pessoaId é nulo para definir o valor do parâmetro adequadamente
                    NpgsqlParameter pessoaIdParam = new NpgsqlParameter("@pessoaid", NpgsqlTypes.NpgsqlDbType.Integer);
                    if (imovel.PessoaId.HasValue)
                    {
                        pessoaIdParam.Value = imovel.PessoaId.Value;
                    }
                    else
                    {
                        pessoaIdParam.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(pessoaIdParam);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public List<Imovel> SelectAll()
        {
            using (var conn = banco.GetConnection())
            {
                using (var cmd = new NpgsqlCommand("SELECT id,endereco,quartos,garagens,aluguel,pessoaid FROM Imovel", conn))
                {
                    using (var leitura = cmd.ExecuteReader())
                    {
                        List<Imovel> listaImovel = new List<Imovel>();
                        while (leitura.Read())
                        {
                            int id = leitura.GetInt32(0);
                            string endereco = leitura.GetString(1);
                            int quartos = leitura.GetInt32(2);
                            int garagens = leitura.GetInt32(3);
                            decimal aluguel = leitura.GetDecimal(4);
                            int? pessoa_id = leitura.IsDBNull(5) ? (int?)null : leitura.GetInt32(5);

                            Imovel imovel = new Imovel(id, endereco, quartos, garagens, aluguel, pessoa_id);
                            listaImovel.Add(imovel);
                        }
                        return listaImovel;
                    }
                }
            }
        }
        public void Delete(Imovel imovel)
        {
            using (var conn = banco.GetConnection())
            {
                using (var cmd = new NpgsqlCommand("Delete From imovel WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", imovel.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Update(Imovel imovel)
        {
            using (var conn = banco.GetConnection())
            {
                using (var cmd = new NpgsqlCommand("UPDATE imovel SET endereco = @endereco, quartos = @quartos, garagens = @garagens, aluguel = @aluguel, pessoaid = @pessoaid WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", imovel.Id);
                    cmd.Parameters.AddWithValue("@endereco", imovel.Endereco);
                    cmd.Parameters.AddWithValue("@quartos", imovel.Quartos);
                    cmd.Parameters.AddWithValue("@garagens", imovel.Garagens);
                    cmd.Parameters.AddWithValue("@aluguel", imovel.Aluguel);

                    // Verifica se pessoaId é nulo para definir o valor do parâmetro adequadamente
                    NpgsqlParameter pessoaIdParam = new NpgsqlParameter("@pessoaid", NpgsqlTypes.NpgsqlDbType.Integer);
                    if (imovel.PessoaId.HasValue)
                    {
                        pessoaIdParam.Value = imovel.PessoaId.Value;
                    }
                    else
                    {
                        pessoaIdParam.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(pessoaIdParam);

                    cmd.ExecuteNonQuery();
                }
            }
        }





    }
}

