using System.Collections.Generic;
using System.Web.Http;
using Dapper.Simple.Database;
using Dapper.Simple.Database.Model;

namespace RestServer.Controllers
{
    [RoutePrefix("api/Estoque")]
    public class ValuesController : ApiController
    {
        [HttpPost]
        [Route("Fornecedores")]
        public IEnumerable<Fornecedor> Fornecedores()
        {
            return DbFactory.Instance.FornecedorRep.BuscarTodos();
        }

        [HttpPost]
        [Route("GravarFornecedor")]
        public Fornecedor GravarFornecedor([FromBody]Fornecedor value)
        {
            return DbFactory.Instance.FornecedorRep.Salvar(value);
        }

        [HttpPost]
        [Route("EditarFornecedor")]
        public Fornecedor EditarFornecedor([FromBody]Fornecedor value)
        {
            return DbFactory.Instance.FornecedorRep.Atualizar(value);
        }

        [HttpPost]
        [Route("ApagarFornecedor")]
        public void ApagarFornecedor([FromBody]Fornecedor value)
        {
            DbFactory.Instance.FornecedorRep.Excluir(value);
        }
    }
}
