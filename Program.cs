using System;

namespace RetPreenchido
{
    class Program
    {
        static void Main(string[] args)
        {
            string sair;
            do
            {
              Console.Clear();
              string ret, erro;
              int Lar, Alt;
              Console.WriteLine("+----------------------+");
              Console.WriteLine("|      Retangulos      |");
              Console.WriteLine("+----------------------+");

              Console.Write("\nAltura  :");
              Alt=Convert.ToInt16(Console.ReadLine());
              Console.Write("Largura :");
              Lar=Convert.ToInt16(Console.ReadLine());
              Console.Write("(C)heio ou (V)azio ?");
              do{
                erro="1";//flag de erro, 0 tudo ok
                  ret=Console.ReadLine().ToUpper();            
                  if       (ret=="C")  { RetPreenchido(Lar,Alt); erro="0";}
                   else if (ret=="V")  { RetVazio(Lar,Alt);erro ="0";}
                  if (erro =="1") {Console.SetCursorPosition(20,6);Console.Beep();}//erro !!

                }while (erro=="1");

                Console.SetCursorPosition(0,8);
              Console.Write("Outro(s)?:");
              sair = Console.ReadLine().ToUpper();
            } while(sair=="S");
            Console.Clear();                 
        }
                  static void RetPreenchido(int L,int A)
                  {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                  int x,y;
                  for (y=0; y!=A;y++)
                  {               
                    for (x=0; x!=L; x++)
                     {
                      Console.SetCursorPosition(30+x,01 + y);   
                      Console.Write(" ");
                     }                
                  }
                  Console.SetCursorPosition(0,03 + y);   
                  Console.ResetColor();  
                  } //fecha RetPreenchido

                   static void RetVazio(int L,int A)
                  {                  
                  int x,y;
                  for (y=0; y!=A;y++)
                  {               
                    for (x=0; x!=L; x++)
                     {
                      if (y==0 || y==A-1) 
                                {Console.BackgroundColor = ConsoleColor.Yellow; }// acende linha
                         else if (x!=0 && x!=L-1)
                                 {Console.BackgroundColor = ConsoleColor.Black; }// apaga coluna
                              else 
                                {Console.BackgroundColor = ConsoleColor.Yellow; }// acende coluna            
                   
                      Console.SetCursorPosition(30+x,01 + y);
                      Console.Write(" ");
                     }                
                  }
                  Console.SetCursorPosition(0,8);   
                  Console.ResetColor();  
                  } //fecha RetVazio
    }
}
