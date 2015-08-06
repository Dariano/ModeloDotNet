using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModeloDotNot.Domain.Profissionais;
using ModeloDotNot.Domain.Restaurantes;
using ModeloDotNot.Domain.Votos;
using Moq;

namespace ModeloDotNet.Domain.Test
{
    [TestClass]
    public class ProfissionalTest
    {
        private readonly Mock<IVotos> _votosMock;

        public ProfissionalTest()
        {
            _votosMock = new Mock<IVotos>();
        }

        [TestMethod]
        public void DeveVotarNoSeuRestauranteFavorito()
        {
            // Criar senário
            var dariano = new Profissional("Dariano");
            var maza = new Restaurante("maza");

            var voto = new Voto(dariano, maza);

            _votosMock.Setup(v => v.Adicionar(voto));
            
            // Executa uma ação
            var urna = new UrnaService(_votosMock.Object);
            var votou = urna.Recebe(voto);

            // Valida o resultado
            _votosMock.VerifyAll();
            Assert.IsTrue(votou);

        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException),
            "Proficional já votou na data corrente.")]
        public void DeveVotarUmaUnicaVezNoDia()
        {
            // Criar senário
            var dariano = new Profissional("Dariano");
            var maza = new Restaurante("maza");

            var voto = new Voto(dariano, maza);

            _votosMock.Setup(v => v.Adicionar(voto));
            _votosMock.Setup(v => v.ObterVoto(It.IsAny<Profissional>(), It.IsAny<DateTime>())).Returns(new Voto(dariano, maza));

            // Executa uma ação
            var urna = new UrnaService(_votosMock.Object);
            urna.Recebe(voto);
        }
    }
}
