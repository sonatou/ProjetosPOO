using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    public class CifraCesar : Criptografia
    {
        private int deslocamento;

        public CifraCesar(int deslocamento)
        {
            this.deslocamento = deslocamento;
        }

        public override string Cifrar(string texto)
        {
            return AplicarDeslocamento(texto, deslocamento);
        }

        public override string Decifrar(string textoCifrado)
        {
            return AplicarDeslocamento(textoCifrado, -deslocamento);
        }

        private string AplicarDeslocamento(string texto, int deslocamento)
        {
            StringBuilder resultado = new StringBuilder();

            foreach (char caractere in texto)
            {
                if (char.IsLetter(caractere))
                {
                    char inicioAlfabeto = char.IsUpper(caractere) ? 'A' : 'a';
                    resultado.Append((char)((caractere - inicioAlfabeto + deslocamento + 26) % 26 + inicioAlfabeto));
                }
                else
                {
                    resultado.Append(caractere);
                }
            }

            return resultado.ToString();
        }
    }
}
