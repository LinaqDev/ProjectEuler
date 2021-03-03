using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaqProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int debugNumber = 12;
            Stopwatch sw = new Stopwatch(); 

            Console.WriteLine("Available problems:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Join(",", GetAllEntities()));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nProvide number of problem to display result. Write 0 to exit.");
            while (true)
            {
                string num = debugNumber > 0 ? debugNumber.ToString() : Console.ReadLine();
                if (num == "0")
                    Environment.Exit(0);

                var instance = GetInstance(num);
                if (instance == null)
                {
                    Console.WriteLine($"Problem number {num} doesnt exist.");
                    continue;
                }

                Console.WriteLine("--------");
                Console.WriteLine($"Problem number {num}");
                sw.Restart();
                Console.Write("Result: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{(instance as IProblem).Run()}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                sw.Stop();
                Console.WriteLine($"Time Taken: {sw.ElapsedMilliseconds} ms");

                if (debugNumber > 0)
                {
                    Console.ReadKey();
                    break;
                }
            }
        }

        public static List<string> GetAllEntities()
        {
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                 .Where(x => typeof(IProblem).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                 .Select(x => x.Name).ToList();
        }

        public static object GetInstance(string num)
        {
            try
            {
                string className = $"Problem{num}";
                var t = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes()).First(x => x.Name == className);
                var objectType = Type.GetType(t.FullName);
                return Activator.CreateInstance(objectType);
            }
            catch (Exception ex)
            {
                return null;
            } 
        }
    
        public static void GARBAGE(int n)
        {
            string R(char c, int amount) => new string(c, Math.Max(0, amount));
            int Clamp(int v, int min, int max) => Math.Max(min, Math.Min(v, max));
            for (int line = 0; line <= n; line++)
            {
                int skip = 2 * line - n;
                string half = $"{R('-', n - line)}{R('*', n)}{R('-', skip)}{R('*', Clamp(n - Math.Abs(skip), 0, n))}{R('-', -skip)}{R('*', n)}{R('-', skip)}{R('*', Clamp(n + skip, 0, n))}{R('-', n - line)}";
                Console.WriteLine($"{half}{half}");
            }
        }

    }
}
