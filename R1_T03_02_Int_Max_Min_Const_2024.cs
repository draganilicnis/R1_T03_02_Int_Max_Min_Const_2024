// https://petlja.org/sr-Cyrl-RS/kurs/14606/5/1318
// https://petlja.org/sr-Latn-RS/kurs/14606/4/1314
// https://petlja.org/sr-Cyrl-RS/kurs/14606/35/1394
// https://petlja.org/sr-Latn-RS/kurs/14606/7/1326
// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/02%20Tipovi_detaljniji_pregled/02%20celobrojni_tip/02%20Baratanje_bitovima
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#BFormatString

using System;
// using System.Numerics;
class R1_T03_02_Int_Max_Min_Const_2024
{
    static void Main()
    {
        Int_00_Const_Ispis();
        Int_01_Max();
    }
    static void Int_00_Const_Ispis()
    {
        int a = 65;
        int b = 0b1000001;      // 0h41 = 65
        int h = 0x41;           // 65
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(h);
        Console.WriteLine((char)h);
        Console.WriteLine(h + 1);
        Console.WriteLine((char)h + 1);
        Console.WriteLine((char)(h + 1));
        Console.WriteLine(a.ToString("X4"));
        Console.WriteLine(a.ToString("x4"));
        // Console.WriteLine(a.ToString("b4")); .NET 8.0    
    }
    static void Int_01_Max()
    {
        Console.WriteLine(" 1. sbyte:      " + sbyte.MaxValue);
        Console.WriteLine(" 2. byte:       " + byte.MaxValue);
        Console.WriteLine(" 3. short:      " + short.MaxValue);
        Console.WriteLine(" 4. ushort:     " + ushort.MaxValue);
        Console.WriteLine(" 5. int:        " + int.MaxValue);
        Console.WriteLine(" 6. uint:       " + uint.MaxValue);
        Console.WriteLine(" 7. long:       " + long.MaxValue);
        Console.WriteLine(" 8. ulong:      " + ulong.MaxValue);
        // Console.WriteLine("9. BigInteger: " + BigInteger.MaxValue);      // Ne kompajlira
        Console.WriteLine("10. float:      " + float.MaxValue);
        Console.WriteLine("11. double:     " + double.MaxValue);
        Console.WriteLine("12. decimal:    " + decimal.MaxValue);
    }
}
