using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Basic_Learning
{
    public class Program
    {
        static void Main(string[] args)
        {
            var longNumber =
                "73167176531330624919225119674426574742355349194934" +
                "96983520312774506326239578318016984801869478851843" +
                "85861560789112949495459501737958331952853208805511" +
                "12540698747158523863050715693290963295227443043557" +
                "66896648950445244523161731856403098711121722383113" +
                "62229893423380308135336276614282806444486645238749" +
                "30358907296290491560440772390713810515859307960866" +
                "70172427121883998797908792274921901699720888093776" +
                "65727333001053367881220235421809751254540594752243" +
                "52584907711670556013604839586446706324415722155397" +
                "53697817977846174064955149290862569321978468622482" +
                "83972241375657056057490261407972968652414535100474" +
                "82166370484403199890008895243450658541227588666881" +
                "16427171479924442928230863465674813919123162824586" +
                "17866458359124566529476545682848912883142607690042" +
                "24219022671055626321111109370544217506941658960408" +
                "07198403850962455444362981230987879927244284909188" +
                "84580156166097919133875499200524063689912560717606" +
                "05886116467109405077541002256983155200055935729725" +
                "71636269561882670428252483600823257530420752963450";

            List<string> greatest = new List<string>();
            List<int> greatestSize = new List<int>();
            for (int i = 0; i + 3 < longNumber.Length; i++)
            {
                var thirteen = new char[4];
                for (int j = 0; j <= 3; j++)
                {
                    thirteen[j] = longNumber[i + j];
                }
                greatest.Add(new string(thirteen));
            }
            foreach (var great in greatest)
            {
                Console.WriteLine(great);
                var count = 1;
                for (int i = 0; i < great.Length; i++)
                {
                    var g = (int)char.GetNumericValue(great[i]);
                    count *= g;
                }
                greatestSize.Add(count);
            }
            Console.WriteLine("Greatest Four:");
            Console.WriteLine(greatestSize.Max());
        }

        static bool IsMultiplyOf3(int bilangan)
        {
            return bilangan % 3 == 0;
        }

        static bool IsMultiplyOf5(int bilangan)
        {
            return bilangan % 5 == 0;
        }

        static bool IsMultiplyOf(int bilangan, int divide)
        {
            return bilangan % divide == 0;
        }

        public static long FibonnaciV1(int bilangan)
        {
            if (bilangan == 0)
            {
                return 0;
            }
            if (bilangan == 1)
            {
                return 1;
            }
            else
            {
                long result = 0;
                long oneBefore = 0;
                long twoBefore = 1;
                for (int i = 1; i <= bilangan; i++)
                {
                    result = oneBefore + twoBefore;
                    twoBefore = oneBefore;
                    oneBefore = result;
                }
                return result;
            }
        }

        public static long FibonnaciV2(int bilangan)
        {
            if (bilangan == 0)
            {
                return 0;
            }
            if (bilangan == 1)
            {
                return 1;
            }
            else
            {
                return FibonnaciV2(bilangan - 1) + FibonnaciV2(bilangan - 2);
            }
        }

        public static long EksponensiV1(int bilangan, int pangkat)
        {
            long result = 1;
            for (int i = 0; i < pangkat; i++)
            {
                result = result * bilangan;
            }
            return result;
        }

        public static long EksponensiV2(int pangkat)
        {
            if (pangkat == 0)
            {
                return 1;
            }
            return EksponensiV2(pangkat - 1) * 2;
        }
    }
}