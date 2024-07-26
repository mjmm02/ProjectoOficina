using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoOficina
{
    public class Reparacao
    {
        string _dataRep;
        string _descricao;
        Mecanico _mec;
        Carro _carro;
        Facturacao _factura;

        public string DataReparacao
        {get; set; }

        public string Descricao { get; set; }

        public Mecanico Mecanico { get; set; }

        public Carro Carro { get; set; }

        public Facturacao Factura { get; set; }


    }
}
