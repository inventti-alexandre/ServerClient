using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Newtonsoft.Json;

namespace Dapper.Simple.Database.Model
{
    [Table("fornecedor")]
    public class Fornecedor
    {
        [Key] //Propriedade quanto o banco tiver auto incremento
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }  

        [Write(false)] //Propriedades que não serão persistidas pelo banco de dados
        [Computed] //Propriedade que não será usada no Update
        [JsonIgnore]
        public IEnumerable<Produto> Produtos { get; set; }

        public Fornecedor()
        {
            this.Produtos = new List<Produto>();
        }
    }
}
