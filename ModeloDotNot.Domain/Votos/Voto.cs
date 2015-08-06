using System;
using ModeloDotNot.Domain.Profissionais;
using ModeloDotNot.Domain.Restaurantes;

namespace ModeloDotNot.Domain.Votos
{
    public class Voto
    {
        public DateTime Data { get; private set; }
        public Profissional Profissional { get; private set; }
        public Restaurante Restaurante { get; private set; }
        

        public Voto(Profissional profissional, Restaurante restaurante)
        {
            this.Data = DateTime.Now;
            this.Profissional = profissional;
            this.Restaurante = restaurante;
        }
    }
}