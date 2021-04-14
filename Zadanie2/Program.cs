using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] jeans = { "tanie", "jeans", "modern", "granatowe", "na zamek" };
            string[] modern = { "jeans", "dresowe", "modern", "granatowe", "czarne", "na guziki" };
            string[] naZamek = { "tanie", "jeans", "klasyczne", "czarne", "na zamek" };

            string[] klasyczne = { "drogie", "klasyczne", "granatowe", "czarne", "na guziki" };
            string[] granatowe = { "tanie", "jeans", "dresowe", "klasyczne", "modern", "granatowe", "na zamek", "na guziki" };
            string[] naGuziki = { "drogie", "klasyczne", "modern", "granatowe", "czarne", "na guziki" };


            string[] A = { "jeans", "modern", "na zamek" };
            string[] B = { "jeans", "klasyczne", "granatowe", "na guziki" };

            double[] wynikiA = { NajwiekszaSuma(jeans, A), NajwiekszaSuma(modern, A), NajwiekszaSuma(naZamek, A) };

            if (NajWynik(wynikiA) == NajwiekszaSuma(jeans, A))
            {
                Console.WriteLine("Pan A szuka spodni jeans");
            }
            if (NajWynik(wynikiA) == NajwiekszaSuma(modern, A))
            {
                Console.WriteLine("Pan A szuka spodni modern");
            }
            if (NajWynik(wynikiA) == NajwiekszaSuma(naZamek, A))
            {
                Console.WriteLine("Pan A szuka spodni na zamek");
            }


            double[] wynikiB = { NajwiekszaSuma(jeans, B), NajwiekszaSuma(klasyczne, B), NajwiekszaSuma(granatowe, B), NajwiekszaSuma(naGuziki, B) };


            if (NajWynik(wynikiB) == NajwiekszaSuma(jeans, B))
            {
                Console.WriteLine("Pan B szuka spodni jeans");
            }
            if (NajWynik(wynikiB) == NajwiekszaSuma(klasyczne, B))
            {
                Console.WriteLine("Pan B szuka spodni klasycznych");
            }
            if (NajWynik(wynikiB) == NajwiekszaSuma(granatowe, B))
            {
                Console.WriteLine("Pan B szuka spodni granatowych");
            }
            if (NajWynik(wynikiB) == NajwiekszaSuma(naGuziki, B))
            {
                Console.WriteLine("Pan B szuka spodni na guziki");
            }

            string[] swieze = { "swieże", "slodkie", "zielone", "lokalne", "lisciaste" };
            string[] ostre = { "swieze", "ostre", "czerwone", "tropikalne", "lisciaste" };
            string[] czerwone = { "mrozone", "ostre", "czerwone", "lokalne", "tropikalne", "bulwowe" };
            string[] mrozone = { "mrożone", "zielone", "czerwone", "tropikalne", "lisciaste" };
            string[] zielone = { "swieze", "mrozone", "zielone", "lokalne", "lisciaste" };
            string[] slodkie = { "swieze", "slodkie", "lokalne", "tropikalne", "lisciaste" };
            string[] lisciaste = { "swieze", "mrozone", "ostre", "slodkie", "zielone", "lokalne", "lisciaste" };

            string[] A1 = { "swieze", "ostre", "czerwone" };
            string[] B1 = { "mrozone", "zielone", "slodkie", "lisciaste" };
            string[] C1 = { "swieze", "zielone", "slodkie", "czerwone" };

            double[] wynikiA1 = { NajwiekszaSuma(swieze, A1), NajwiekszaSuma(ostre, A1), NajwiekszaSuma(czerwone, A1) };

            if (NajWynik(wynikiA1) == NajwiekszaSuma(swieze, A1))
            {
                Console.WriteLine("Pan A1 szuka warzyw swierzych");
            }
            if (NajWynik(wynikiA1) == NajwiekszaSuma(ostre, A1))
            {
                Console.WriteLine("Pan A1 szuka warzyw ostrych");
            }
            if (NajWynik(wynikiA1) == NajwiekszaSuma(czerwone, A1))
            {
                Console.WriteLine("Pan A1 szuka warzyw czerwonych");
            }

            double[] wynikiB1 = { NajwiekszaSuma(mrozone, B1), NajwiekszaSuma(zielone, B1), NajwiekszaSuma(slodkie, B1), NajwiekszaSuma(lisciaste, B1) };

            if (NajWynik(wynikiB1) == NajwiekszaSuma(mrozone, B1))
            {
                Console.WriteLine("Pan B1 szuka warzyw mrozonych");
            }
            if (NajWynik(wynikiB1) == NajwiekszaSuma(zielone, B1))
            {
                Console.WriteLine("Pan B1 szuka warzyw zieloych");
            }
            if (NajWynik(wynikiB1) == NajwiekszaSuma(slodkie, B1))
            {
                Console.WriteLine("Pan B1 szuka warzyw slodkich");
            }
            if(NajWynik(wynikiB1) == NajwiekszaSuma(lisciaste, B1))
            {
                Console.WriteLine("Pan B1 szuka warzyw lisciastych");
            }

            double[] wynikiC1 = { NajwiekszaSuma(swieze, C1), NajwiekszaSuma(zielone, C1), NajwiekszaSuma(slodkie, C1), NajwiekszaSuma(czerwone, C1) };

            
            if (NajWynik(wynikiC1) == NajwiekszaSuma(swieze, C1))
            {
                Console.WriteLine("Pan C1 szuka warzyw swierzych");
            }
            if (NajWynik(wynikiC1) == NajwiekszaSuma(zielone, C1))
            {
                Console.WriteLine("Pan C1 szuka warzyw zielonych");
            }
            if (NajWynik(wynikiC1) == NajwiekszaSuma(slodkie, C1))
            {
                Console.WriteLine("Pan C1 szuka warzyw slodkich");
            }
            if (NajWynik(wynikiC1) == NajwiekszaSuma(czerwone, C1))
            {
                Console.WriteLine("Pan C1 szuka warzyw czerwonych");
            }
            Console.ReadKey();
        }

        public static double NajwiekszaSuma(string[] tab1, string[] tab2)
        {
            double n = 0.0;
            for (int i = 0; i < tab1.Length; i++)
            {
                for (int j = 0; j < tab2.Length; j++)
                {
                    if (tab2[j] == tab1[i])
                        n++;
                }
            }

            return (n / tab2.Length );
        }

        public static double NajWynik(double[] tab3)
        {
            
            double max = tab3[0];
            for (int l = 0; l < tab3.Length; l++)
            {
                if (tab3[l] > max)
                    max = tab3[l];
            }
            return max;
        }
        

        
    }
}
