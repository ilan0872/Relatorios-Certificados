using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

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
	                                                        when valido = 'false' then 'VENCIDO'
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

        // Consulta na tabela 
        public IEnumerable<Certificados> GetCertificados(string status, string mes, string tipo)
        {
            DataTable dataTable = new DataTable();
            pgsqlConnection = new NpgsqlConnection(ConnString);
            pgsqlConnection.Open();

            string vencidos = status;
            status = "true";


            string consultaCertificados = @"SELECT EMPRESAS.CODIGOEMPRESA, EMPRESAS.FILIAL, 
                                            CASE
	                                            WHEN CERTIFICADOS.DATAVENCIMENTO > CURRENT_DATE  THEN 'ATIVO'
	                                            WHEN CERTIFICADOS.DATAVENCIMENTO < CURRENT_DATE  THEN 'VENCIDO'
                                            END AS VALIDO, 
                                            EMPRESAS.NOMEEMPRESA, CERTIFICADOS.TIPO, CERTIFICADOS.DATAVENCIMENTO
                                            FROM CERTIFICADOS
                                            INNER JOIN EMPRESAS ON EMPRESAS.IDEMPRESA = CERTIFICADOS.IDEMPRESA 
                                            WHERE CERTIFICADOS.VALIDO = 'true'
                                            ";
            
          
           if (vencidos != "<Todos>" && mes != "<Todos>" && tipo != "<Todos>")
           {
                var data = new DateTime(DateTime.Now.Year, Convert.ToInt32(mes), 01);
                var ultimoDia = DateTime.DaysInMonth(data.Year, data.Month);
                consultaCertificados += $@" AND CERTIFICADOS.VALIDO = '{status}' AND CERTIFICADOS.DATAVENCIMENTO
                                           BETWEEN '{DateTime.Now.Year}-{mes}-01' AND '{DateTime.Now.Year}-{mes}-{ultimoDia}' AND CERTIFICADOS.TIPO = '{tipo}' ";
           }
           else if (vencidos != "<Todos>" && mes != "<Todos>" && tipo == "<Todos>")
           {
                var data = new DateTime(DateTime.Now.Year, Convert.ToInt32(mes), 01);
                var ultimoDia = DateTime.DaysInMonth(data.Year, data.Month);
                consultaCertificados += $@" AND CERTIFICADOS.VALIDO = '{status}' AND CERTIFICADOS.DATAVENCIMENTO
                                           BETWEEN '{DateTime.Now.Year}-{mes}-01' AND '{DateTime.Now.Year}-{mes}-{ultimoDia}' ";
           }
           else if (vencidos != "<Todos>" && mes == "<Todos>" && tipo != "<Todos>")
           {
                if (vencidos != "ATIVO")
                {
                    consultaCertificados += $@" AND CERTIFICADOS.VALIDO = '{status}' AND CERTIFICADOS.DATAVENCIMENTO < CURRENT_DATE AND CERTIFICADOS.TIPO = '{tipo}' ";
                }
                else
                {
                    consultaCertificados += $@" AND CERTIFICADOS.VALIDO = '{status}' AND CERTIFICADOS.DATAVENCIMENTO > CURRENT_DATE AND CERTIFICADOS.TIPO = '{tipo}' ";
                }
           }
           else if (status == "<Todos>" && mes != "<Todos>" && tipo != "<Todos>")
           {
               var data = new DateTime(DateTime.Now.Year, Convert.ToInt32(mes), 01);
               var ultimoDia = DateTime.DaysInMonth(data.Year, data.Month);
               consultaCertificados += $@" AND CERTIFICADOS.DATAVENCIMENTO BETWEEN '{DateTime.Now.Year}-{mes}-01' AND '{DateTime.Now.Year}-{mes}-{ultimoDia}' 
                                          AND CERTIFICADOS.TIPO = '{tipo}' ";
           }
           else if (vencidos != "<Todos>" && mes == "<Todos>" && tipo == "<Todos>")
           {
                if (vencidos != "ATIVO")
                {
                    consultaCertificados += $@" AND CERTIFICADOS.VALIDO = '{status}' AND CERTIFICADOS.DATAVENCIMENTO < CURRENT_DATE ";
                }
                else
                {
                    consultaCertificados += $@" AND CERTIFICADOS.VALIDO = '{status}' AND CERTIFICADOS.DATAVENCIMENTO > CURRENT_DATE ";
                }
           }
           else if (vencidos == "<Todos>" && mes != "<Todos>" && tipo == "<Todos>")
           {
               var data = new DateTime(DateTime.Now.Year, Convert.ToInt32(mes), 01);
               var ultimoDia = DateTime.DaysInMonth(data.Year, data.Month);
               consultaCertificados += $@" AND CERTIFICADOS.DATAVENCIMENTO BETWEEN '{DateTime.Now.Year}-{mes}-01' AND '{DateTime.Now.Year}-{mes}-{ultimoDia}' ";
           }
           else if (vencidos == "<Todos>" && mes == "<Todos>" && tipo != "<Todos>")
           {
                consultaCertificados += $@" AND CERTIFICADOS.TIPO = '{tipo}' ";
            }

                consultaCertificados += "ORDER BY 1, 2 ";


           NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(consultaCertificados, pgsqlConnection);
           Adpt.Fill(dataTable);

            List<Certificados> certificados = new List<Certificados>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var certificado = new Certificados()
                {
                    CodigoEmpresa = (int)(dataTable.Rows[i][0]),
                    Filial = (int)dataTable.Rows[i][1],
                    Valido = dataTable.Rows[i][2].ToString(),
                    NomeEmpresa = dataTable.Rows[i][3].ToString(),
                    Tipo = dataTable.Rows[i][4].ToString(),
                    DataDeVencimento = dataTable.Rows[i][5].ToString().Substring(0, 10)
                };
                certificados.Add(certificado);
            }
            QuantidadeCertificados = certificados.Count;
            ListaCertificados = certificados;

            return ListaCertificados;
        }
    }
}
