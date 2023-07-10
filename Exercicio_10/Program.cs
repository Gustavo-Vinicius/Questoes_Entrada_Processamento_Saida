Console.WriteLine("Mostrador de relacionamentos\n\n");

bool Igual=false;
bool NaoIgual=false;
bool Maior=false;
bool Menor=false;
bool MaiorOuIgual=false;
bool MenorOuIgual=false;

Console.WriteLine("Digite o primero numero : ");
int primeiroNumero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero : ");
int segundoNumero = Convert.ToInt32(Console.ReadLine());

if (primeiroNumero ==  segundoNumero) Igual = true;
if (primeiroNumero != segundoNumero) NaoIgual = true;
if (primeiroNumero > segundoNumero ) Maior = true;
if (primeiroNumero < segundoNumero ) Menor = true;
if (primeiroNumero >= segundoNumero ) MaiorOuIgual = true;
if (primeiroNumero <= segundoNumero ) MenorOuIgual = true;

Console.WriteLine("\nIgual = "+Igual);
Console.WriteLine("Não Igual = "+NaoIgual);
Console.WriteLine("Maior = "+Maior);
Console.WriteLine("Menor = "+Menor);
Console.WriteLine("Maior ou igual = "+MaiorOuIgual);
Console.WriteLine("Menor ou igual = "+MenorOuIgual);