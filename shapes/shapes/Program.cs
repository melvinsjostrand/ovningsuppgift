// See https://aka.ms/new-console-template for more information

using shapes;
using System.Drawing;


public class program{



public static void main(){


Shape s = null;



        Console.WriteLine("skriv en höjd");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("skriv en bredd");
        float width = float.Parse(Console.ReadLine());
        int val = 1;

while(val != 0)
        {
            Console.WriteLine("vad vill du göra? triangle(1) eller rectangle(2)");
            val = int.Parse(Console.ReadLine());

            if (val == 1)
            {
                 s = new Rectangle(width, height);

            }
            else if (val == 2)
            {
                s = new Rectangle(width, height);
   
            }
            else
            {
                continue;
            }
                    Console.WriteLine(s.Area());
                    Console.WriteLine(s.Circumference());


        }

    }

}