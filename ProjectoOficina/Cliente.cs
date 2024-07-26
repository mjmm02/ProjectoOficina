using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoOficina
{
    public class Cliente
    {

        int _numCliente;
        string _nomeCliente;
        List<Carro> listaCarros;

        public int NumCliente
        {
            get { return _numCliente; }
            set { _numCliente = value; }
        }
        public string NomeCliente
        {
            get { return _nomeCliente; }
            set { _nomeCliente = value; }
        }
        public List<Carro> ListaDeCarros
        {
            get { return listaCarros; }
            set { listaCarros = value; }
        }

        public Cliente()
        {
            
        }

        public void AdicionarCarro(Carro carro)
        {
            listaCarros.Add(carro);
        }
    }
}
