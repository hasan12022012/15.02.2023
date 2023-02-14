using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;

namespace task1
{
    internal static class ExtentionMethods
    {
        //IsOdd() - int obyektlər üçün həmin obyektin tək ədəd olub olmadığını geri qaytaran(true/false) method
        public static bool IsOdd(this int numOdd)
        {
            if (numOdd % 2 != 0) return true;

            else return false;
        }

        //IsEven() - int obyektlər üçün həmin obyektin cüt ədəd olub olmadığını geri qaytaran(true/false) method
        public static bool IsEven(this int numEven)
        {
            if (numEven % 2 == 0) return true;

            else return false;
        }

        //IsContainsDigit() - string obyektlər üçün həmin obyektin daxilində digit character olub olmamasını
        //geri qaytaran(true/false) metod
        public static bool IsContainsDigit(this string name)
        {
            if (name == null) return false;

            foreach (var cr in name)
            {
                if (char.IsDigit(cr))
                    return true;
            }

            return false;
        }

        //ToCapitalize() - String-lər üçün ToCapitalize adlı extention metod yaradırsınız.
        //Bu metod string dəyərini capitalaize edib geri qaytarmalıdır.
        public static string ToCapitalize(this string str1)
        {
            string newStr = Char.ToUpper(str1[0]) + str1.Substring(1).ToLower();
            return newStr;
        }

        //GetValueIndexes() - string-lər üçün parameter olaraq göndərilən charin stringin hansı indexlerində yerləşdiyini tapan və
        //tapdığı bütün indexləri array olaraq geri qaytaran metod(heç bir dəyər tapılmazsa geriyə boş (0 uzunluqlu) int[] qayıdır)
        public static int[] GetValueIndexes(this string str2,char cr)
        {
            int[] indexes=new int[0];
            
            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i] == cr)
                {
                    Array.Resize(ref indexes, indexes.Length+1);
                    indexes[indexes.Length-1] = i;
                }
                
            }
            return indexes;

        }

        
        
    }
}
