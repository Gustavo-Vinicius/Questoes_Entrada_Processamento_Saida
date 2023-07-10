Console.WriteLine("Digite seu identificador :");
string id = Console.ReadLine();
Console.WriteLine("Digite seu código da peça :");
string codigo = Console.ReadLine();
Console.WriteLine("Digite o preço unitario da peça :");
double preco_unitario = double.Parse(Console.ReadLine());
Console.WriteLine("Quantidade vendida :");
int qtd_vendida = Convert.ToInt32(Console.ReadLine());

double comissao = ((preco_unitario*qtd_vendida)*0.05);

Console.WriteLine($"Comissão é {comissao}");