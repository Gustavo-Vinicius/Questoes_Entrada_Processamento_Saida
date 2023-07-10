Console.WriteLine("Digite sua temperatura em graus celsius : ");
int grausCelcius = Convert.ToInt32(Console.ReadLine());

double fahrenheit = (9 * grausCelcius + 160 ) / 5;

Console.WriteLine($"{grausCelcius}°c corresponde à {fahrenheit} °F");