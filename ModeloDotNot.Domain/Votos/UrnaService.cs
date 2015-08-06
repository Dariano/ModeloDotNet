using System;

namespace ModeloDotNot.Domain.Votos
{
    public class UrnaService
    {
        private readonly IVotos _votos;

        public UrnaService(IVotos votos)
        {
            _votos = votos;
        }

        public bool Recebe(Voto voto)
        {
            var jaVotou = _votos.ObterVoto(voto.Profissional, voto.Data);

            if(jaVotou != null) throw new ApplicationException("Proficional já votou na data corrente.");

            _votos.Adicionar(voto);

            return true;
        }
    }
}