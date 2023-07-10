using System.Globalization;

Console.WriteLine("Digite o tempo da viagem : ");
int tempo_viagem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a velocidade media : ");
int velMedia = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

int distancia = tempo_viagem * velMedia;

int litros_usados = distancia / 12;

Console.Write($"Será utilizado {litros_usados} na viagem.");