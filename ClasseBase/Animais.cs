using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.ClasseBase
{
    public class Animais
    {
        public string? Grupo { get; set; }

        public void Acao()
        {
            Console.WriteLine("O animal está caçando...");
        }
    }
}