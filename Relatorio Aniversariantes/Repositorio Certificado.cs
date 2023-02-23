using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relatorio_Certificados
{
    public class RepositorioCertificado
    {
        // conexao com o banco para pegar as informaçoes
        static readonly string serverName = "192.168.1.5";
        static readonly string porta = "5432";
        static readonly string userName = "postgres";
        static readonly string senha = "wl@post2013\r\n";
        static readonly string bancoDeDados = "wlvalidador";

        NpgsqlConnection pgsqlConnection = null;

        readonly string ConnString = $@"Server={serverName};Port={porta};User Id={userName};Password={senha};Database={bancoDeDados};";

        public int QuantidadeCertificados { get; set; }

        //metodo para pegar a lista
        public List<Certificados> ListaCertificados { get; set; }

        // pega na tabela certificados os dados se o certificado esta valido ou nao
        public DataTable GetValidadeCertificado()
        {
            DataTable dataTable = new DataTable();

            pgsqlConnection = new NpgsqlConnection(ConnString);
            pgsqlConnection.Open();

            string consultaValidadeCertificados = @"SELECT DISTINCT  
                                                        case 
	                                                        when valido = 'false' then 'INATIVO'
	                                                        when valido = 'true' then 'ATIVO'
                                                        end as valido
                                                        FROM certificados 
                                                        ORDER BY 1";

            NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(consultaValidadeCertificados, pgsqlConnection);
            Adpt.Fill(dataTable);
            return dataTable;

        }

        // 
        public DataTable GetMes()
        {   

            DataTable dataTable = new DataTable();

            pgsqlConnection = new NpgsqlConnection(ConnString);
            pgsqlConnection.Open();

            string consultaMes = @"SELECT DISTINCT  (datavencimento) as MES
                                        FROM certificados 
                                        ORDER BY 1";
            NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(consultaMes, pgsqlConnection);
            Adpt.Fill(dataTable);
            return dataTable;

        }

        // Pega na tabela do banco de dados qual o tipo do certificado A1, A3 e CPF.
        public DataTable GetTipoCertificado()
        {
            DataTable dataTable = new DataTable();

            pgsqlConnection = new NpgsqlConnection(ConnString);
            pgsqlConnection.Open();

            string consultaTipoCertificado = @"SELECT DISTINCT  (tipo) as tipocertificado
                                                    FROM certificados 
                                                    ORDER BY 1";

            NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(consultaTipoCertificado, pgsqlConnection);
            Adpt.Fill(dataTable);
            return dataTable;
        }
    }
}
