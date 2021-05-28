using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoCelular
{
    class ConversorCaracteres
    {
        private string textoConvertido;
        public string Converte(char textoEntrada)
        {
            switch (textoEntrada)
            {
                case ' ': textoConvertido = "0"; break;
                case 'A': textoConvertido = "2"; break;
                case 'B': textoConvertido = "22"; break;
                case 'C': textoConvertido = "222"; break;
                case 'D': textoConvertido = "3"; break;
                case 'E': textoConvertido = "33"; break;
                case 'F': textoConvertido = "333"; break;
                case 'G': textoConvertido = "4"; break;
                case 'H': textoConvertido = "44"; break;
                case 'I': textoConvertido = "444"; break;
                case 'J': textoConvertido = "5"; break;
                case 'K': textoConvertido = "55"; break;
                case 'L': textoConvertido = "555"; break;
                case 'M': textoConvertido = "6"; break;
                case 'N': textoConvertido = "66"; break;
                case 'O': textoConvertido = "666"; break;
                case 'P': textoConvertido = "7"; break;
                case 'Q': textoConvertido = "77"; break;
                case 'R': textoConvertido = "777"; break;
                case 'S': textoConvertido = "7777"; break;
                case 'T': textoConvertido = "8"; break;
                case 'U': textoConvertido = "88"; break;
                case 'V': textoConvertido = "888"; break;
                case 'W': textoConvertido = "9"; break;
                case 'X': textoConvertido = "99"; break;
                case 'Y': textoConvertido = "999"; break;
                case 'Z': textoConvertido = "9999"; break;
            }
            return textoConvertido;
        }
    }
}
