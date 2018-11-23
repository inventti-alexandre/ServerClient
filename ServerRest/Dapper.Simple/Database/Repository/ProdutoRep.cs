using System;
using System.Data;
using System.Linq;
using Dapper.Contrib.Extensions;
using Dapper.Simple.Database.Model;
using MySql.Data.MySqlClient;

namespace Dapper.Simple.Database.Repository
{
    public class ProdutoRep
    {
        private MySqlConnection Connection { get; set; }

        public ProdutoRep(MySqlConnection Connection)
        {
            this.Connection = Connection;
        }

        public Produto BuscarPorId(Int32 Id)
        {
            try
            {
                return Connection.Get<Produto>(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (this.Connection.State != ConnectionState.Closed)
                    this.Connection.Close();
            }
        }

        public Produto Salvar(Produto produto)
        {
            try
            {
                var sql = "insert into produto " +
                          "(Nome, Preco, Quantidade, UM, IdFornecedor) " +
                          "Values " +
                          "(" +
                          "     @Nome, " +
                          "     @Preco, " +
                          "     @Quantidade," +
                          "     @UM," +
                          "     @IdFornecedor" +
                          ");";

                sql += "SELECT last_insert_id();";

                produto.Id = this.Connection.Query<Int32>(sql, produto).Single();

                return produto;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if (this.Connection.State != ConnectionState.Closed)
                    this.Connection.Close();
            }
        }
    }
}
