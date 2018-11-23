using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteRest.Model
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
    }
}
