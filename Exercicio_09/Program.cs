int DIAS_NO_ANO = 365;

int DIAS_NO_MES = 30;

Console.WriteLine("Digite sua idade.");
Console.WriteLine("Anos :");
int anos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Meses:");
int meses = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dias:");
int dias = Convert.ToInt32(Console.ReadLine());

dias += (anos * DIAS_NO_ANO) + (meses * DIAS_NO_MES);

Console.WriteLine("\n \nA sua idade em dias é " + dias);