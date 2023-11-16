using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4
{
    public class CifraXor : Criptografia
    {
        private string chave;

        public CifraXor(string chave)
        {
            this.chave = chave;
        }

        public override string Cifrar(string texto)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < texto.Length; i++)
            {
                resultado.Append((char)(texto[i] ^ chave[i % chave.Length]));
            }

            return resultado.ToString();
        }

        public override string Decifrar(string textoCifrado)
        {
            return Cifrar(textoCifrado);
        }
    }
}
