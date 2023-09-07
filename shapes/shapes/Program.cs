using shapes;
using System.Drawing;









Console.WriteLine("skriv en höjd");
float height = float.Parse(Console.ReadLine());
Console.WriteLine("skriv en bredd");
float width = float.Parse(Console.ReadLine());
Shape s = null;
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

        s = new shapes.Rectangle(width, height);

    }
    else
    {
        continue;
    }
    Console.WriteLine(s.Area());
    Console.WriteLine(s.Circumference());


}
