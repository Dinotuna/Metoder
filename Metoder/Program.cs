using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

static void Hello32()
{
    for(int i = 0; i < 36; i++)
    {
        Console.WriteLine("Hello World!");
    }
}



Hello32();

Console.WriteLine("Skriv ett nummer");

string tal = Console.ReadLine();


static void Kvadrat(string tal)
{
    int num = int.Parse(tal);
    int result = num * num;
    Console.WriteLine(result);
}


Kvadrat(tal);



float a = 12.5f;
float b = 5.5f;


static float Multi(float a, float b)
{
    float multiResult = a * b;
    return multiResult;
}

float mulitResult = Multi(a, b);
Console.WriteLine(mulitResult);



double x = 5.1;
double y = 10.2;

static double RightTriangleArea(double x, double y)
{
    double RightTriangleAreaResult = 0.5 * x * y;
    return RightTriangleAreaResult;
}

double RightTriangleAreaResult = RightTriangleArea(x, y);
Console.WriteLine(RightTriangleAreaResult);


float r = 2.3f;

static float CircleArea(float r)
{
    float CircleAreaResult = 3.14159265f * r * r;
    return CircleAreaResult;
}

float CircleAreaResult = CircleArea(r);
Console.WriteLine(CircleAreaResult);



static int GetNumberImput()
{
    int result;
    string svar;

    while(true)
    {
        Console.WriteLine("Skriv ett tal");
        svar = Console.ReadLine();

        if (int.TryParse(svar, out result))
        {
            return result;
        }

        else
        {
            Console.WriteLine("Du skrev inte in ett nummer");
        }
    }
}

int nummer = GetNumberImput();
Console.WriteLine("Numret var" + " " + nummer);





static int GetChoice(string val1, string val2, string val3)
{

    while(true)
    {
        Console.WriteLine("Välj ett val");
        Console.WriteLine(val1);
        Console.WriteLine(val2);
        Console.WriteLine(val3);
        Console.WriteLine("Skriv 1, 2 eller 3 för att välja ett val\n" );

        string svar = Console.ReadLine();


        if (svar == "1" || svar == "2" || svar =="3")
        {
            return int.Parse(svar);
        }

        else
        {
            Console.WriteLine("Du måste skriva en siffra\n");
        }


    }
}

int val = GetChoice("Hus", "Bil", "Spel");

Console.WriteLine("Du valde nummer " + val);



Console.ReadLine();