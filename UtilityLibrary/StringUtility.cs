namespace UtilityLibrary
{
    public class StringUtility
    {

        /// <summary>
        /// Melakukan operasi penjumlahan dari 2 string
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns>return string if valid and empty string if not valid</returns>
        public static string PlusOperationOnString(string str1, string str2)
        {
            bool CheckIfStringIsValidNumber(string str)
            {
                return str.Any(str => char.IsDigit(str) == true);
            }

            int GetStringDigit(string str, int digit) => digit <= str.Length ? int.Parse(str[str.Length - digit].ToString()) : 0;

            if (CheckIfStringIsValidNumber(str1) && CheckIfStringIsValidNumber(str2))
            {
                var result = new List<int>();
                var simpan = 0;
                var maxLength = Math.Max(str1.Length, str2.Length);
                for (int i = 1; i <= maxLength; i++)
                {
                    var number1 = GetStringDigit(str1, i);
                    var number2 = GetStringDigit(str2, i);
                    var tambah = number1 + number2 + simpan;
                    var sisaHasilBagi = tambah % 10;
                    var pembagian = tambah / 10;
                    result.Add(sisaHasilBagi);
                    simpan = pembagian;
                }

                if (simpan > 0)
                {
                    result.Add(simpan);
                }
                result.Reverse();
                return string.Concat(result);
            }
            return "";
        }

        public static long FindAdjacentDigit(string inputStr, int inputDigit)
        {
            long maxProduct = 0;
            for (int i = 0; i <= inputStr.Length - inputDigit; i++)
            {
                var tempProduct = SumString(inputStr.Substring(i, inputDigit));
                if (tempProduct > maxProduct)
                {
                    maxProduct = tempProduct;
                }
            }
            return maxProduct;
        }

        /// <summary>
        /// Menjumlahkan angka dalam string
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns>Jika bilangan dapat dijumlahkan akan mengembalikan hasil tetapi jika tidak dapat dijumlahkan akan mengembalikan 1.</returns>
        public static long SumString(string inputStr)
        {
            long result = 1;
            for (int i = 0; i < inputStr.Length; i++)
            {
                var intStr = inputStr[i].ToString();
                var intCheck = int.TryParse(intStr, out int outParse);
                if (intCheck == true) result *= int.Parse(intStr);
            }
            return result;
        }
    }
}