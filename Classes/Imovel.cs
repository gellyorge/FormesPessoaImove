using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormesPessoaImove.Classes
{
    public class Imovel
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public int Quartos { get; set; }
        public int Garagens { get; set; }
        public decimal Aluguel { get; set; }
        public int? PessoaId { get; set; }

        public Imovel(string endereco, int quartos, int garagens, decimal aluguel, int? pessoaId)
        {

            Endereco = endereco;
            Quartos = quartos;
            Garagens = garagens;
            Aluguel = aluguel;
            PessoaId = pessoaId;
        }
        public Imovel(int id, string endereco, int quartos, int garagens, decimal aluguel, int? pessoaId = null)
        {
            Id = id;
            Endereco = endereco;
            Quartos = quartos;
            Garagens = garagens;
            Aluguel = aluguel;
            PessoaId = pessoaId;
        }
        public override string ToString()
        {
            return $"{Id}, {Endereco}, {Quartos}, {Garagens}, {Aluguel}, {PessoaId}";
        }

    }
}
