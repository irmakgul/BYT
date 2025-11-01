using System;
using System.Globalization;
using CalculatorApp;
using Tut2_s20123;

namespace CalculatorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 3 argüman bekleniyor: A B op
            if (args.Length != 3)
            {
                Console.Error.WriteLine("Kullanım: calculator <A> <B> <op:+-*/>");
                return;
            }

            // A ve B sayı olmalı
            if (!double.TryParse(args[0], NumberStyles.Float, CultureInfo.InvariantCulture, out var a) ||
                !double.TryParse(args[1], NumberStyles.Float, CultureInfo.InvariantCulture, out var b))
            {
                Console.Error.WriteLine("Hata: A ve B sayısal olmalıdır (örn. 12.5).");
                return;
            }

            // İşlem operatörü (ilk karakter)
            char op = args[2][0];

            try
            {
                var calc = new Calculator(a, b, op);
                var result = calc.Compute();

                // Sonuç yazdırılır
                Console.WriteLine(result.ToString(CultureInfo.InvariantCulture));
            }
            catch (DivideByZeroException)
            {
                Console.Error.WriteLine("Hata: Sıfıra bölme.");
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine($"Hata: {ex.Message}");
            }
        }
    }
}