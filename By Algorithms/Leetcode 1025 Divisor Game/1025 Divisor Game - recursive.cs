﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1025_divisor_game___recursive
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public bool DivisorGame(int N)
        {
            var table = new int[1001];
            for (int i = 0; i < 1001; i++)
                table[i] = -1;
            table[1] = 0;
            table[2] = 1;
            table[3] = 0;

            return DivisorGameRecursive(N, table);
        }

        private static bool DivisorGameRecursive(int N, int[] table)
        {
            if (table[N] != -1)
            {
                return table[N] == 1;
            }

            for (int i = 1; i < N; i++)
            {
                if (N % i == 0)
                {
                    if (!DivisorGameRecursive(N - i, table))
                    {
                        table[N] = 1;
                        return true;
                    }
                }
            }

            table[N] = 0;
            return false;
        }    
    }
}
