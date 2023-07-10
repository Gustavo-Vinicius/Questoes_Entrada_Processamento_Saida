Console.WriteLine("Digite o raio :");
double r = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite a altura :");
double h = Convert.ToDouble(Console.ReadLine());
double volume = Math.PI*r*r*h;
Console.WriteLine($"O volume é igual a {volume}");