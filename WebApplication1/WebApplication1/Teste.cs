using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    [TestClass]
   public class Teste
    {
        private class TestClassAttribute : Attribute
        {
            public void Ao_digitar_o_nome_william_a_soma_sera_79_e_ele_nao_sera_primo()
            {
                var palavras = new loopLetra();
                var retorno =  palavras.verificaPrimo("h");

                object Assert = null;
                Assert.Equals(8);
            }
        }
    }
}
