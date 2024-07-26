using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoOficina
{
    internal class Marcacao
    {
        string _data;
        Cliente _cliente;
        Mecanico _mecanico;
        Carro _carro;

        public string Data { get; set; }
        public Cliente Cliente { get; set; }
        public Mecanico Mecanico { get; set; }
        public Carro Carro { get; set; }


    }
}
