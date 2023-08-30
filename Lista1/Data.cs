using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPoo
{
    class Data
    {
        public int dia;
        public int mes;
        public int ano;


        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;

            Console.WriteLine("\n {0}/{1}/{2} foi um lindo dia", dia, mes, ano);
        }

        public void ImprimirData()
        {
            Console.WriteLine("\n {0}/{1}/{2} foi um lindo dia", dia, mes, ano);
        }

        public void ImprimirDataPorExtenso(string cidade)
        {
            Console.WriteLine("\n {0}/{1}/{2} foi um lindo dia na cidade de {3}", dia, mes, ano, cidade);
        }
    }
}
