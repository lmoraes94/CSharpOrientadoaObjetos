using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrientacaoObjetos.Interface;

namespace OrientacaoObjetos.ClasseDerivada
{
    public class Celular : IusoPessoal
    {

        public bool bateria { get; set; }
        public int valorCredito { get; set; }
        public void colocarCredito(int valor)
        {
            valorCredito = valorCredito + valor;
        }


        public void estaLigado()
        {
            if (bateria == true)
            {
                Console.WriteLine("O celular está ligado");
         }
            else
            {
                Console.WriteLine("O celular está desligado");
            }
        }

        public void recarregar()
        {
            if (bateria == false)
            {
                Console.WriteLine("Precisa recarregar o celular");
            }else{
                Console.WriteLine("O celular ainda tem bateria");
            }
        }
    }
}