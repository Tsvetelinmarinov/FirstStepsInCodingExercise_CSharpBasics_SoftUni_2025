/**
 * 04. Vacation Books List
 */



/**
 * 1. Брой страници в текущата книга – цяло число в интервала [1…1000]
 * 2. Страници, които прочита за 1 час – цяло число в интервала [1…1000]
 * 3. Броят на дните, за които трябва да прочете книгата – цяло число в интервала [1…1000]
 */


int pagesCount = int.Parse(Console.ReadLine());
int pagesReadedPerHour = int.Parse(Console.ReadLine());
int daysForReading = int.Parse(Console.ReadLine());


int hoursNeeded = pagesCount / pagesReadedPerHour;
int hoursNeededPerDay = hoursNeeded / daysForReading;


Console.WriteLine($"{hoursNeededPerDay}");