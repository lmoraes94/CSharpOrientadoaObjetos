using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrientacaoObjetos.ClasseAbstrata;

namespace OrientacaoObjetos.ClasseDerivada
{
    public class Computador : Equipamento
    {
        public override void Descricao(string descricao)
        {
            Console.WriteLine(descricao);
        }

        public override string Informacoes()
        {
            return "Computador";
        }
    }
}