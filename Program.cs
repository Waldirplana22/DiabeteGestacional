using System;

class Program {
  public static void Main (string[] args) {
     
        {
            int
            valorGlicemia;


            Console.Clear();
          
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("---- Diabetes Gestacional ----\n");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Digite o valor de glicemia (em mg/dL)..: ");
            valorGlicemia = Convert.ToInt32(Console.ReadLine());

            if (valorGlicemia < 92)

            {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Valor Referência: < 92\n");
            }

            else if (valorGlicemia >= 92 && valorGlicemia < 126)
            {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Compatível com Diabetes Gestacional\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Valor Referência entre 92 e 125\n");
            }

            else if (valorGlicemia >= 126)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Beep(); Console.Beep(); Console.Beep();
                Console.WriteLine("Diabetes Mellitus na Gravidez\n");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Valor Referência: >= 126\n");
                Console.ResetColor();
            }
        }
    }
}
