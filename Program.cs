double x, y;
string local;


Console.WriteLine("--- cuadrante Cartesiano ---\n");

Console.WriteLine("ingrese el puento deseado.");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Coordenada x: ");
x = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("Coordenada y: ");
y = Convert.ToDouble(Console.ReadLine());

if (x == 0 && y == 0) local = "el origen";
else if (x == 0) local = "el eje de ordenadas";
else if (y == 0) local = "el eje de abscissas";
else if (y > 0)

{
    if (x > 0)
        local = "el cuadrante 1";
    else
        local = "el cuadrante 2";
}
else
{
    if (x < 0)
        local = "el cuadrante 3";
    else
        local = "el cuadrante 4";
}
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"\nen puento ({x}, {y}) Se convierte en {local}."); 
Console.ResetColor();