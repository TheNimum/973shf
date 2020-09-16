using System;

namespace _973shf
{
    class Program
    {
        static void Main(string[] args)
        {
           int min = 0;
           int max = 140;
          int[] testvalue = new int[] {110, 120, 120, 130, 140, 0 };
          string[] namevalue = new string[]{"kolorado", "radionbilarna", "flumride", "lisebergståget", "balder", "sagoslottet"}; 
           namevalue[0] = 110;



               
            System.Console.WriteLine($" [1]kolorado: minst 110cm  \n [2]radiobilarna: minst 120cm \n [3]flumride: minst 120cm \n [4]lisebergståget: minst 130cm \n [5]balder: minst 140cm \n [6]sagoslottet: ingen begränsning \n ");
                System.Console.WriteLine("hur lång är du ?: ");
                int height = Int32.Parse(Console.ReadLine());
                
                    for(int i=0; i<namevalue.Length; i++ )
                    {
                        if(height >=max)
                        {
                            Console.WriteLine($"du får åka följande åka:");
                            Console.WriteLine(namevalue[i]);
                        }else if(testvalue[i] =<height)
                        {
                            testvalue
                        }

                     }
                        

                    
                        
                        
                        
                        

                   

        }
    }
}
