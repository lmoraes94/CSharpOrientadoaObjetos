using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    public class Person
    {
        public string? Name { get; private set; }
        public int Age { get; private set; }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void alterarInfos (string newName, int newAge)
        {
            this.Name = newName;
            this.Age = newAge;
        }
    }
}