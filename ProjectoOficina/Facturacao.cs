using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoOficina
{
    public class Facturacao
    {
        string _dataFact;
        int _valorFact;
        Cliente _cliente;

        public string DataFact { get; set; }
        public int ValorFact { get; set; }
        public Cliente cliente { get; set; }

    }
}
