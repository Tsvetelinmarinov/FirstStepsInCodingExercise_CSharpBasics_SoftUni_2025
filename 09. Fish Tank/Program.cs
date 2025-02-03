/**
 * 09. Fish Tank
 */



/**
 * 1. Дължина в см – цяло число в интервала [10 … 500]
 * 2. Широчина в см – цяло число в интервала [10 … 300]
 * 3. Височина в см – цяло число в интервала [10… 200
 * 4. Процент – реално число в интервала [0.000 … 100.000]
 *
 * 85 75 47 17
 * 
 * 105 77 89 18.5
 */


int poolLength = int.Parse(Console.ReadLine());
int poolWidth = int.Parse(Console.ReadLine());
int poolHeight = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());


percentage /= 100;


int totalVolume = poolLength * poolWidth * poolHeight;

double totalVolumeInLiters = totalVolume * 0.001;

totalVolumeInLiters *= (1 - percentage);


Console.WriteLine($"{totalVolumeInLiters}");