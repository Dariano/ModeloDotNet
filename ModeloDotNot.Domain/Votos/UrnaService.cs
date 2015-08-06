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
            _votos.Adicionar(voto);

            return true;
        }
    }
}