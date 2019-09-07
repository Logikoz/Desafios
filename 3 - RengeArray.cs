/*
Escreva uma função chamada range que recebe dois argumentos, start (início) e end (fim), e retorna um array contendo todos os 
números a partir do valor start até o valor end (incluindo-o).

Em seguida, escreva a função sum que recebe um array de números como argumento e retorna a soma desses números. 

Como desafio bônus, modifique a sua função range para aceitar um terceiro argumento opcional que indica o tamanho do "incremento" 
usado para construir o array. Se nenhum valor for atribuído ao tamanho do incremento, o array de elementos será percorrido em 
incrementos de um, correspondendo ao comportamento original. A chamada à função range(1, 10, 2) deve retornar [1, 3, 5, 7, 9]. 
Certifique-se de que funcione também com valores negativos, fazendo com que range(5, 2, -1) produza [5, 4, 3, 2].
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logikoz.Desafios
{
    internal static class RangeArray
    {
        public static int[] Range(int a, int b, int j = 1) => Fill(a, b, j);

        public static int Sum(int[] arr) => arr.Sum();

        private static int[] Fill(int a, int b, int j)
        {
            int max = a > b ? a : b;
            int min = a > b ? b : a;
            HashSet<int> hs = new HashSet<int>();
            for(int i = min; i <= max; i += Math.Abs(j)) _ = hs.Add(i);

            return j < 0 ? hs.ToArray().Reverse().ToArray() : hs.ToArray();
        }
    }
}
