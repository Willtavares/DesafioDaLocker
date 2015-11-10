using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class loopLetra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        public bool verificaPrimo() {
           //letrinhas
           
            var letras = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] lArr = letras.ToCharArray();

            //palavrinha
            var palavra = txtpalavra.Text;
            char[] pArr = palavra.ToCharArray();

            var soma = 0;

            for (int i = 0; i < pArr.Length; i++)//percorre a PALAVRA
            {
                //noite
                //pArr[0] = n
                for (int j = 0; j < lArr.Length; j++)
                {
                    if (lArr[j] == pArr[i])
                    {
                        soma = soma + (j+1);
                    }
                }
            }
            Response.Write("A soma das letras é: " + soma + "<br>");

          
                if (soma == 1) return false;
                for (int i = 2; i < soma; i++)
                {
                    if (soma % i == 0) return false;
                }
                return true;
            
        }


        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (verificaPrimo()) {
                Response.Write("É primo");
            }
            else {
                Response.Write("Não é primo");
            }
        }
    }
}