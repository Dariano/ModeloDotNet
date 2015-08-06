using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDotNot.Domain.Restaurantes
{
    public class Restaurante
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public Restaurante(string nome)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
        }

    }
}
