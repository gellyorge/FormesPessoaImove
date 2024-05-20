using Npgsql;

namespace FormesPessoaImove.Db
{
    public class Banco
    {
        private readonly string connString =
            "Host=localhost;" +
            "Username=postgres;" +
            "Password=admin;" +
            "Database=CadastroImovelPessoas";
        private readonly NpgsqlConnection conn;

        public Banco()
        {
            conn = new NpgsqlConnection(connString);
            conn.Open();            
        }

        public NpgsqlConnection GetConnection()
        {
            return conn;
        }

        
    }
}
