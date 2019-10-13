using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TesteXUnit
{
    public class TesteCriacaoFilmes
    {
        [Theory]
        public TesteCriacaoFilmes(double a)
        {
            double b = 1;
            var teste = Assert.Equal(a, b);

        }
    }
}
