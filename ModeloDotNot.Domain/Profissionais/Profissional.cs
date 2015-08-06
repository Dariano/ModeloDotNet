using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDotNot.Domain.Profissionais
{
    public class Profissional
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public Profissional(string nome)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
        }
    }
}
