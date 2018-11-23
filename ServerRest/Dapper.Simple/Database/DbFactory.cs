using System;
using System.Data;
using Dapper.Simple.Database.Repository;
using MySql.Data.MySqlClient;

namespace Dapper.Simple.Database
{
    public class DbFactory
    {
        private static DbFactory _instance = null;

        private MySqlConnection Connection { get; set; }
        public ProdutoRep ProdutoRep { get; set; }
        public FornecedorRep FornecedorRep { get; set; }

        private DbFactory()
        {
            try
            {
                Conectar();

                this.ProdutoRep = new ProdutoRep(this.Connection);
                this.FornecedorRep = new FornecedorRep(this.Connection);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Não foi possível instanciar a DbFactory.", e);
            }
        }

        public static DbFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DbFactory();
                }

                return _instance;
            }
        }

        private void Conectar()
        {
            try
            {
                var stringConexao = "Server=localhost;" +
                                    "Port=3306;" +
                                    "Database=estoque;" +
                                    "Uid=root;" +
                                    "Pwd=root;" +
                                    "SslMode=None";

                this.Connection = new MySqlConnection(stringConexao);

                this.Connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw new Exception("Não foi possível conectar ao banco de dados.", e);
            }
            finally
            {
                if(this.Connection.State != ConnectionState.Closed)
                    this.Connection.Close();
            }
        }

    }
}
