using System;
using System.Collections.Generic;
namespace KMP_Algorithm
{
    public class Program
    {
        public static int [] pi (string P)
        {
            int [] result = new int [P.Length];
            result[0] = 0;
            int k = 0;
            for(int i = 1 ; i < P.Length ; i++)
            {
                while(k>0 && P[i] != P[k])
                    {
                        k = result[k-1];
                    }
                if(P[i] == P[k])
                {
                    k++;
                }
                result[i] = k;
            }
            return result;
        }

        public static List<int> KMP (string text , string p)
        {
            List<int> result = new List<int>();
            int k = 0;
            int [] Pi = new int [p.Length];
            Pi = pi(p);
            for(int i=0 ; i<text.Length ; i++)
            {
                while(k>0 && text[i] != p[k])
                {
                    k = Pi[k-1];
                }
                if(text[i] == p[k])
                {
                    k++;
                    if(k == p.Length) 
                    {
                        result.Add(i-k+1);
                        k = Pi[p.Length-1];
                    }
                }
            } 
            return result;
        }
    }
}