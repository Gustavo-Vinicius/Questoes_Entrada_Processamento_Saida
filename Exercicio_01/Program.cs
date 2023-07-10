Console.WriteLine("Digite a quantidade mínima do estoque :");
int quantidade_minima = Int16.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade maxima do estoque :");
int quantidade_maxima = Int16.Parse(Console.ReadLine());
int estoque_medio = (quantidade_minima + quantidade_maxima)/2;
Console.Write("Estoque medio : " + estoque_medio);