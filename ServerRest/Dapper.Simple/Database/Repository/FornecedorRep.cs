using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper.Contrib.Extensions;
using Dapper.Simple.Database.Model;

namespace Dapper.Simple.Database.Repository
{
    public class FornecedorRep
    {
        private MySqlConnection Connection { get; set; }

        public FornecedorRep(MySqlConnection Connection)
        {
            this.Connection = Connection;
        }

        public List<Fornecedor> BuscarTodos()
        {
            try
            {
                var fornecedores = this.Connection.GetAll<Fornecedor>().ToList();
                return fornecedores;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                if(this.Connection.State != ConnectionState.Closed)
                    this.Connection.Close();
            }
        }

        public Fornecedor Salvar(Fornecedor fornecedor)
        {
            try
            {
                fornecedor.Id = Convert.ToInt32((this.Connection.Insert(fornecedor)));

                return fornecedor;
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

        public Fornecedor Atualizar(Fornecedor fornecedor)
        {
            try
            {
                this.Connection.Update(fornecedor);

                return fornecedor;
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

        public void Excluir(Fornecedor fornecedor)
        {
            try
            {
                this.Connection.Delete(fornecedor);
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
