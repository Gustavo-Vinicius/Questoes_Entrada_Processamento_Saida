Console.WriteLine("Digite a contação do dólar :");
double cotacao_dolar = Double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor em dolarés :");
double valor_em_dolares = double.Parse(Console.ReadLine());

double resultado_conversao = cotacao_dolar * valor_em_dolares;

Console.Write("resultado : " + resultado_conversao);