using System;

namespace Samples{
	public class Puzzle1{
		public static int Main(string[] args)
		{
            var i = 0;
            if (args.Length == 1)
            {
                if (IsNumber(args[0]))
                {
                    i = Convert.ToInt32(args[0]);
                    Console.WriteLine("{0} {1}", i, (IsOdd(i) ? "Es impar" : "Es par"));
                }
                else Console.WriteLine("No es un número");
            }
            else
                Console.WriteLine("usar: Puzzle1 [number]");
			return 0;
		}
        
		static bool IsOdd(int i){
			//incorrect
			//return i % 2 == 1;
			//correct
			return i % 2 != 0;
		}
        static bool IsNumber(string s) {
            if (s.IndexOf("1") != -1 ||
            s.IndexOf("2") != -1 ||
            s.IndexOf("3") != -1 ||
            s.IndexOf("4") != -1 ||
            s.IndexOf("5") != -1 ||
            s.IndexOf("6") != -1 ||
            s.IndexOf("7") != -1 ||
            s.IndexOf("8") != -1 ||
            s.IndexOf("9") != -1 ||
            s.IndexOf("0") != -1)
                return true;
            return false;
        }

    }
}
