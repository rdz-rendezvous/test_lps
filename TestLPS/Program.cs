using System.Globalization;
using System.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Soal B");

        int inputInt;
        Console.Write("Input: ");
        inputInt = Convert.ToInt32(Console.ReadLine());

        string inputSoalB = inputInt.ToString();

        int length = inputSoalB.Length;

        foreach(var input in inputSoalB)
        {
            string angka = "";
            for(int i = 1; i < length; i++)
            {
                angka += "0";
            }
            Console.WriteLine(input + angka);
            length--;
        }


        Console.WriteLine("Soal C");
        Console.Write("Input: ");

        string inputSoalC;
        inputSoalC = Console.ReadLine();
        string result = string.Empty;

        for(int i = 0; i<inputSoalC.Length; i++)
        {
            if (!result.Contains(inputSoalC[i]))
            {
                result += inputSoalC[i];
            }
        }

        result = result.Replace(" ", "");

        foreach (var input in result)
        {
            int ctr = 0;
            for (int i = 0; i < inputSoalC.Length; i++)
            {
                if (input == inputSoalC[i])
                {
                    ctr++;
                }

            }
            Console.WriteLine(input + "-" + ctr);
        }

        Console.WriteLine("Soal D");
        Console.Write("Input: ");

        int inputSoalD;
        inputSoalD = Convert.ToInt32(Console.ReadLine());


        for(int i = 1; i<= inputSoalD; i++)
        {
            if (i % 5 == 0 && i != 5)
            {
                Console.Write("IDIC ");
            }
            else if (i % 6 == 0 && i != 6)
            {
                Console.Write("LPS ");
            }
            else
            {
                Console.Write(i+" ");
            }
        }

        Console.WriteLine("Soal E");
        Console.Write("Input: ");

        string inputSoalE;
           
        inputSoalE = Console.ReadLine();

        if (!string.IsNullOrEmpty(inputSoalE))
        {
            Console.WriteLine("Format Judul: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(inputSoalE.ToLower()));

            Console.WriteLine("Format Biasa : " + inputSoalE[0] + inputSoalE.Substring(1).ToLower());
        }



    }
}