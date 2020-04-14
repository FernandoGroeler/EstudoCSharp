using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.Behavioral.Visitor
{
    public static class ListExtensions
    {
        private static readonly Random _rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;

            while (n > 1)
            {
                n--;

                int k = _rng.Next(n + 1);

                T value = list[k];

                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
