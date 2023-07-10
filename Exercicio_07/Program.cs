Console.WriteLine("Digite sua temperatura em fahrenheit : ");
int fahrenheit = Convert.ToInt32(Console.ReadLine());

double celsius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine($"{celsius}°F corresponde à {fahrenheit}°C");