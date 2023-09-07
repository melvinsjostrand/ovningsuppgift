// See https://aka.ms/new-console-template for more information

using shapes;
using System.Drawing;







        float width;
        float height;

Console.WriteLine("skriv en höjd");
height = float.Parse(Console.ReadLine());
Console.WriteLine("skriv en bredd");
width = float.Parse(Console.ReadLine());
shape s = null;
int val = 1;
while (val != 0)
        {
            Console.WriteLine("vad vill du göra? triangle(1) eller rectangle(2)");
            val = int.Parse(Console.ReadLine());

            if (val == 1)
            {
               
                s = new Triangle(width, height);

            }
            else if (val == 2)
            {
               
                s = new rectangle(width, height);
   
            }
            else
            {
                continue;
            }
                    Console.WriteLine(s.Area());
                    Console.WriteLine(s.Circumference());


        }

