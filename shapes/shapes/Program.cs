// See https://aka.ms/new-console-template for more information

using shapes;
using System.Drawing;

float height;
float width;
float Circumference = 0;
float area = 0;

int val = 1;

while(val != 0)
        {
    Console.WriteLine("vad vill du göra? triangle(1) eller rectangle(2)");
            val = int.Parse(Console.ReadLine());

            if (val == 1)
            {
                Console.WriteLine("skriv en längd");
                 width = float.Parse(Console.ReadLine());
                Console.WriteLine("skriv en höjd");
                 height = float.Parse(Console.ReadLine());
                triangle s = new triangle(width, height);
        Console.WriteLine(s.Area());
        Console.WriteLine(s.Circumference());
    }
            else if (val == 2)
            {
                Console.WriteLine("skriv en bredd");
                 width = float.Parse(Console.ReadLine());
                Console.WriteLine("skriv en höjd");
                 height = float.Parse(Console.ReadLine());
                rectangle s = new rectangle(width, height);
        Console.WriteLine(s.Area());
        Console.WriteLine(s.Circumference() );
    }
            else
            {
                continue;
            }

 
        }

