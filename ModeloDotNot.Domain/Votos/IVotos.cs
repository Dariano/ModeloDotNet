using System;
using ModeloDotNot.Domain.Profissionais;

namespace ModeloDotNot.Domain.Votos
{
    public interface IVotos
    {
        void Adicionar(Voto voto);
        Voto ObterVoto(Profissional profissional, DateTime dataDoVoto);
    }
}