using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormesPessoaImove.Classes
{
    public class Pessoa
    {
        public int Id {  get; set; }
        public string Nome { get; set; }
        public string Email {  get; set; }
        public string Endereco { get; set; }
        public Pessoa(string nome,string email,string endereco)
        {
            Nome = nome;
            Email = email;
            Endereco = endereco;
        }
        public Pessoa(int id,string nome, string email, string endereco)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Endereco = endereco;
        }
        public override string ToString()
        {
            return $"id:{Id}, {Nome}";
        }
    }
}
