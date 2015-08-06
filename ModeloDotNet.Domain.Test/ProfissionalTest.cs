using System;
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


        [TestMethod]
        public void DeveVotarNoSeuRestauranteFavorito()
        {
            // Criar senário
            var dariano = new Profissional("Dariano");
            var maza = new Restaurante("maza");

            var voto = new Voto(dariano, maza);

            var votosMock = new Mock<IVotos>();
            votosMock.Setup(v => v.Adicionar(voto));
            
            // Executa uma ação
            var urna = new UrnaService(votosMock.Object);
            var votou = urna.Recebe(voto);

            // Valida

            votosMock.VerifyAll();
            Assert.IsTrue(votou);

        }
    }
}
