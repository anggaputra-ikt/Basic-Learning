using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using UtilityLibrary;

namespace Basic_Learning
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var angka = 0.355555555555555555;
            //var angkaLength = angka.ToString().Length;
            //var fraksi = "1";
            //for (int i = 1; i < angkaLength - 1; i++)
            //{
            //    fraksi = $"{fraksi}0";
            //}
            //fraksi = $"{angka * int.Parse(fraksi)}/{fraksi}";
            //Console.WriteLine(fraksi);

            Console.WriteLine(MultiplyOperationOnString("123", "122"));
        }

        public static string MultiplyOperationOnString(string str1, string str2)
        {
            bool CheckIfStringIsValidNumber(string str)
            {
                return str.Any(str => char.IsDigit(str) == true);
            }

            int GetStringDigit(string str, int digit) => digit <= str.Length ? int.Parse(str[str.Length - digit].ToString()) : 0;

            if (CheckIfStringIsValidNumber(str1) && CheckIfStringIsValidNumber(str2))
            {
                if (int.Parse(str1) > int.Parse(str2))
                {
                    var swap = str1;
                    str1 = str2;
                    str2 = swap;
                }

                var result = new List<int>();
                var simpanResult = new List<string>();
                var maxLength = Math.Max(str1.Length, str2.Length);
                for (int i = 1; i <= maxLength; i++)
                {
                    var simpan = 0;
                    var number1 = GetStringDigit(str1, i);
                    for (int j = 1; j <= maxLength; j++)
                    {
                        var number2 = GetStringDigit(str2, j);
                        var kali = (number1 * number2) + simpan;
                        var sisaHasilBagi = kali % 10;
                        var pembagian = kali / 10;

                        result.Add(sisaHasilBagi);
                        simpan = pembagian;
                    }
                    if (simpan > 0)
                    {
                        result.Add(simpan);
                    }
                    result.Reverse();
                    if (i >= 2)
                    {
                        result.Add(0);
                    }
                    simpanResult.Add(string.Concat(result));
                    result.RemoveAll(x => x != 0);
                }

                var simpanHasil = simpanResult[0].ToString();
                for (int i = 1; i < simpanResult.Count(); i++)
                {
                    simpanHasil = StringUtility.PlusOperationOnString(simpanHasil, simpanResult[i].ToString());
                }
                return simpanHasil;
            }
            return "";
        }
    }
}