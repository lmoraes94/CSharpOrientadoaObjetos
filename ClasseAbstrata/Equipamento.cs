using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos.ClasseAbstrata
{
    public abstract class Equipamento
    {
        public string? name { get; set; }
        public abstract string Informacoes();

        public abstract void Descricao(string descricao);

        public virtual void LigaDesliga(bool ligaDesliga)
        {
            if (ligaDesliga == true)
            {
                Console.WriteLine($"O {name} está ligado");
            }else{
                Console.WriteLine($"O {name} está desligado");
            }
        }
    }
}