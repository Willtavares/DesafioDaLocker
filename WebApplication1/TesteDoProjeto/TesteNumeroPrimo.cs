using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1;



namespace TesteDoProjeto
{
    [TestClass]
    public class TesteNumeroPrimo
    {
        private class TestClassAttribute : System.Attribute
        {
            public void Ao_digitar_o_nome_william_a_soma_sera_79_e_ele_nao_sera_primo()
            {
                var palavras = new loopLetra();
                var retorno = palavras.verificaPrimo("william");

                object Assert = null;
                Assert.Equals(79);
            }
        }

    }
}
