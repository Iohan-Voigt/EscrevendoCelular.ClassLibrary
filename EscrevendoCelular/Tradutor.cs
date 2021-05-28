using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoCelular
{
    public class Tradutor
    {
        private readonly ConversorCaracteres conversorCaracteres = new ConversorCaracteres();
        private string textoFormatado = "";
        private List<string> textoListString = new List<string>();
        public string Traduzir(string textoEntrada) {
            textoEntrada = textoEntrada.ToUpper();

            if (Validador(textoEntrada).Equals("valido")){
                char[] textoChar = textoEntrada.ToCharArray();
                foreach (char a in textoChar) 
                        textoListString.Add(conversorCaracteres.Converte(a));
                foreach (var a in textoListString){                    
                    if (textoFormatado == ""){
                        textoFormatado = a.ToString();
                    }
                    else {
                        char[] priLis = a.ToCharArray();
                        char[] priStr = textoFormatado.ToCharArray();
                        if (priLis[0].Equals(priStr[priStr.Length - 1]))
                            textoFormatado += $"_{a.ToString()}";
                        else
                            textoFormatado += a.ToString();
                    }                   
                    
                }

            }else
                textoFormatado = Validador(textoEntrada);
            
            return textoFormatado;
        }

        #region Métodos Privados
        private string Validador(string texto) {
            string resultado = "valido";
            if (texto.Length > 255)
                resultado = "Texto muito longo";
            else if (texto.Length <= 0)
                resultado = "Sem texto";
            return resultado;
        }
        #endregion
    }
}
