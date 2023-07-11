namespace Basic_Learning
{
    public class LearningBase
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public LearningBase()
        {
            Id = 1;

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

        public static long FibonnaciV3(int bilangan)
        {
            if (bilangan == 0)
            {
                return 1;
            }
            if (bilangan == 1)
            {
                return 2;
            }
            if (bilangan == 2)
            {
                return 3;
            }
            else
            {
                long result = 0;
                long oneBefore = 2;
                long twoBefore = 1;
                for (int i = 1; i < bilangan; i++)
                {
                    result = oneBefore + twoBefore;
                    twoBefore = oneBefore;
                    oneBefore = result;
                }
                return result;
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

        public static long LargestProduct(string longNumber, int digit)
        {
            List<string> greatest = new List<string>();
            List<long> greatestSize = new List<long>();
            for (int i = 0; i + (digit - 1) < longNumber.Length; i++)
            {
                var thirteen = new char[digit];
                for (int j = 0; j <= (digit - 1); j++)
                {
                    thirteen[j] = longNumber[i + j];
                }
                greatest.Add(new string(thirteen));
            }
            foreach (var great in greatest)
            {
                long count = 1;
                for (int i = 0; i < great.Length; i++)
                {
                    var g = (int)char.GetNumericValue(great[i]);
                    count *= g;
                }
                greatestSize.Add(count);
            }
            return greatestSize.Max();
        }

        public static List<int> PrimeFactor(long bilangan, int beratPrima)
        {
            List<int> isPrima = new List<int>();
            List<int> notPrima = new List<int>();
            for (int i = 2; i < beratPrima; i++)
            {
                if (isPrima.Contains(i) == false && notPrima.Contains(i) == false)
                {
                    isPrima.Add(i);
                    for (int j = i; j < beratPrima; j++)
                    {
                        notPrima.Add(i * j);
                    }
                }

            }

            var result = bilangan;
            List<int> primeFactors = new List<int>();
            for (int i = 0; i < isPrima.Count; i++)
            {
                while (result % isPrima[i] == 0)
                {
                    result = bilangan / isPrima[i];
                    if (primeFactors.Contains(isPrima[i]) == false)
                    {
                        primeFactors.Add(isPrima[i]);
                    }
                }
            }
            return primeFactors;
        }
    }
}