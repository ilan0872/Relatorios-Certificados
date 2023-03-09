using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio_Aniversariantes
{
    public class RepositorioPass
    {
        static readonly string serverName = "192.168.1.5";
        static readonly string porta = "5432";
        static readonly string userName = "postgres";
        static readonly string senha = "wl@post2013\r\n";
        static readonly string bancoDeDados = "autenticacao";

        NpgsqlConnection pgsqlConnection = null;

        readonly string ConnString = $@"Server={serverName};Port={porta};User Id={userName};Password={senha};Database={bancoDeDados};";


        public void Insert(string name, string pass)
        {
            pgsqlConnection = new NpgsqlConnection(ConnString);
            pgsqlConnection.Open();

            var insert = @"INSERT INTO lcxa (nome, pass) 
                                   VALUES(@Nome, @Pass)";

            var cmd = pgsqlConnection.CreateCommand();
            cmd.CommandText = insert;

            cmd.Parameters.AddWithValue(@"Nome", name);
            cmd.Parameters.AddWithValue(@"Pass", pass);
            cmd.ExecuteNonQuery();
        }
    }
}
