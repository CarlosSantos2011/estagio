using Alura.LeilaoOnline.Core;
using Xunit;
using System.Text;

namespace Alura.LeilaoOnline.Tests
{
    public class LanceCtor
    {
        [Fact]
        public void LancaArgumentExceptionDadoValorNegativo()
        {
            //Arranje
            var valorNegativo = -100;

            //Assert
            Assert.Throws<System.ArgumentException>(
                
                () => new Lance(null, valorNegativo)
                );
        }
    }
}
