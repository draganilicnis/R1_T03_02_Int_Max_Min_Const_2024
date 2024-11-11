// https://petlja.org/sr-Cyrl-RS/kurs/14606/5/1318
// https://petlja.org/sr-Latn-RS/kurs/14606/4/1314
// https://petlja.org/sr-Cyrl-RS/kurs/14606/35/1394
// https://petlja.org/sr-Latn-RS/kurs/14606/7/1326
// https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/02%20Tipovi_detaljniji_pregled/02%20celobrojni_tip/02%20Baratanje_bitovima
// https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#BFormatString
// https://github.com/draganilicnis/R1_T03_02_Int_Max_Min_Const_2024/blob/main/R1_T03_02_Int_Max_Min_Const_2024.cs

using System;
// using System.Numerics;
class R1_T03_02_Int_Max_Min_Const_2024
{
    static void Main()
    {
        Int_00_Const_Ispis();
        Int_01_Max();
        Int_02_HEX_BIN_Raad();
        Real_03_Const();
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
        Console.WriteLine("13. Half:       " + Half.MaxValue);
    }

    static void Int_02_HEX_BIN_Raad()
    {
        // https://petlja.org/sr-Latn-RS/biblioteka/r/Zbirka/binarni_i_heksadekadni_zapis_broja
        // Procitaj heksadekadni, ispisi dekadni
        string sh = "1F";
        ulong h = Convert.ToUInt64(sh, 16); // ulong h = Convert.ToUInt64(Console.ReadLine(), 16);
        Console.WriteLine(h);

        // Procitaj binarni, ispisi dekadni
        string sb = "01000001";
        ulong b = Convert.ToUInt64(sb, 2); // ulong b = Convert.ToUInt64(Console.ReadLine(), 2);
        Console.WriteLine(b);
    }
    static void Real_03_Const()
    {
        // https://petlja.org/sr-Latn-RS/kurs/14606/4/1314
        double x = 3;
        x = 3;
        x = 3.0;
        x = +3;
        x = +3.0;
        x = 3e0;
        x = 3.0e0;
        x = +3e0;
        x = +3.0e0;
        x = 3E0;
        x = 3.0E0;
        x = +3E0;
        x = +3.0E0;
        x = 0.3e1;
        x = .3e1;
        x = +0.3e1;
        x = +.3e1;
        x = 0.03e2;
        // https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#BFormatString
        x = 3.49999999;
        int b = (int)x;
        Console.WriteLine(x);
        Console.WriteLine(x.ToString("0.00"));
        Console.WriteLine(x.ToString("F2"));
        Console.WriteLine(x.ToString("E"));
        Console.WriteLine(x.ToString("e4"));
        Console.WriteLine(x.ToString("E8"));
        Console.WriteLine(x.ToString("C3"));
        Console.WriteLine(b.ToString("D"));
        Console.WriteLine(x.ToString("F3"));
        Console.WriteLine(x.ToString("G3"));
        Console.WriteLine(x.ToString("N1"));
        Console.WriteLine(x.ToString("P2"));
        Console.WriteLine(b.ToString("X"));
    }
}
