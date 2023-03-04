// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 1: Operaciones aritmeticas");

Console.WriteLine("Ingrese un número: ");
    int n1 = Convert.ToInt32(Console.ReadLine()); //5

Console.WriteLine("Ingrese otro número: ");
    int n2 = Convert.ToInt32(Console.ReadLine()); //3

double n1d = n1;
double n2d = n2;

int suma= n1 + n2;
Console.WriteLine(n1 + "+" + n2 + "=" + suma);

int resta = n1 - n2;
Console.WriteLine(n1 + "-" + n2 + "=" + resta);

int multiplicación = n1 * n2;
Console.WriteLine(n1 + "*" + n2 + "=" + multiplicación);

double división = n1d / n2d;
Console.WriteLine(n1 + "/" + n2 + "=" + división);

int div = n1 / n2;
Console.WriteLine("(ENTEROS)" + n1 + "/" + n2 + "=" + div);

int mod = n1 % n2;
Console.WriteLine(n1 + "%" + n2 + "=" + mod);

// ejercicio no. 2
Console.WriteLine("Ejercicio 2: operaciones booleanas");

if (n1 > n2)
{
    Console.WriteLine(n1 + ">" + n2);
}else if (n2 > n1){
Console.WriteLine(n2 + ">" + n1);
}else if (n1 == n2)
{
    Console.WriteLine(n1 + "=" + n2);
}
