using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Interface
{
    public interface IusoPessoal
    {
        void recarregar();
        void colocarCredito(int valor);
        void estaLigado();   
    }
}