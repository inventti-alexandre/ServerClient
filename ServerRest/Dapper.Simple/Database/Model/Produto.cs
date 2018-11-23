using System;
using Dapper.Contrib.Extensions;
using Newtonsoft.Json;

namespace Dapper.Simple.Database.Model
{
    [Table("produto")]
    public class Produto
    {
        [Key]//Propriedade quanto o banco tiver auto incremento
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public Double Preco { get; set; }
        public Double Quantidade { get; set; }
        public String UM { get; set; }
        public Int32 IdFornecedor { get; set; }

        [Write(false)] //Propriedades que não serão persistidas pelo banco de dados
        [Computed] //Propriedade que não será usada no Update
        [JsonIgnore]
        public Fornecedor Fornecedor { get; set; }
    }
}
