using System;
using System.Collections.Generic;
using System.Text;

namespace NewProjects
{
    public class Calculadora
    {
        private List<string> Listahistorico;
        private string data;

        public Calculadora(string data)
        {
            this.data= data;
            Listahistorico = new List<string>();

       }
        public int Soma(int x1 , int x2)
        {
            int soma = x1 +x2;
            Listahistorico.Insert(0,"resultdo -> " + soma + "-->" + data);
            return soma;
        }
        public int Subtrair(int x1, int x2)
        {
            int sub = x1 - x2;
            Listahistorico.Insert(0, "resultdo -> " + sub + "-->" + data);
            return sub;
        }
        public int Multiplicar(int x1, int x2)
        {
            int mult = x1 * x2;
            Listahistorico.Insert(0, "resultdo -> " + mult + "-->" + data);
            return mult;
        }
        public int Dividir(int x1, int x2)
        {
            Listahistorico.Insert(0, "resultdo -> " + x1/x2 + "-->" + data);
            return x1 / x2;
        }
        public List<string> historico()
        {
            Listahistorico.RemoveRange(3, Listahistorico.Count - 3);
            return Listahistorico;
        }
    }
}
