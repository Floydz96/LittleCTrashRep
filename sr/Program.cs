using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao1
{
    class Program
    {
        private static int RAND_VALUE = 20;

        static void Main(string[] args)
        {
            bool valueReached = true;
            int tents = 0;
            Random rd = new Random();
            
            while (valueReached)
            {
                int value = rd.Next(1, RAND_VALUE);

                Console.WriteLine("o valor randomico é " + value);

                if (value == 18)
                {
                    Console.WriteLine("Valor é igual a 18");
                    Console.WriteLine(tents + " tentativas para chegar a este valor.");
                    valueReached = true;
                    break;
                }

                Console.WriteLine("buscando novos possíveis valores" + Environment.NewLine);
                tents = tents + 1;
                Console.Title = "" + tents;
            }
            Console.WriteLine("Bem-Vindo " + Environment.UserName);
            Console.WriteLine("Caminho do diretorio atual " + Environment.SystemDirectory + Environment.NewLine);

            Console.WriteLine("Digite uma cor de fundo, Cores disponíveis: RED, BLUE, BLACK, YELLOW, PURPLE, ORANGE. Cor padrão, BLACK.");

            string s = Console.ReadLine().ToString();

            Console.BackgroundColor = transformColor(s);

            if(!(s.Equals("BLACK") || s.Equals("black")))
            {
                Console.WriteLine("Cor padrão definida.");
            }

            Console.WriteLine("COR " + s + " definida.");

            Exec2 sc = new Exec2();

            sc.execMediaCalculator();

            Console.WriteLine("Insira um valor para factorial. ");
            string i = Console.ReadLine();
            Console.WriteLine(" Fatorial de " + i  + " é: " + sc.factorialFromNumber(int.Parse(i)));

        }
         static ConsoleColor transformColor(string s)
         {
            s = s.ToUpper();
        
            switch (s)
            {
                case "ORANGE":
                    return ConsoleColor.DarkYellow;
                case "PURPLE":
                    return ConsoleColor.Magenta;
                case "YELLOW":
                    return ConsoleColor.Yellow;
                case "BLACK":
                    return ConsoleColor.Black;
                case "BLUE":
                    return ConsoleColor.Blue;
                case "RED":
                    return ConsoleColor.Red;
                default:
                    return ConsoleColor.Black;
            }
        }
    }
    class Exec2
    {
        public void execMediaCalculator()
        {
            Console.WriteLine("Insira uma nota e seu peso. i.e '3.5 2' onde 3.5 é a nota, e 2 o peso.");

            double totalNoteSum = 0, totalWeight = 0;

            while (true)
            {
                string noteAndWeight = Console.ReadLine();
                try
                {
                    string[] splited = noteAndWeight.Split(' ');
                    float currentNote = float.Parse(splited[0]);

                    if (currentNote == -1) break;

                    float currentWeight = float.Parse(splited[1]);
                    totalWeight += currentWeight;

                    totalNoteSum += currentNote * currentWeight;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Insira apenas números!.");
                    continue;
                }

            }
                double sum = totalNoteSum / totalWeight;

                Console.WriteLine("A média das notas é " + sum);
        }

        public long factorialFromNumber(int number)
        {
            long sum = 0;

            for(int i = 0; i <= number; ++i)
            {
                sum += i * (i + 1);
            }

            return sum;
        }

    }
}
