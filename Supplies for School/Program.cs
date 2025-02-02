/**
 * 05. Supplies for School
 */



/**
 * 
 * • Пакет химикали - 5.80 лв.
 * • Пакет маркери - 7.20 лв.
 * • Препарат - 1.20 лв (за литър)
 */


double penPrice = 5.8;
double markerPrice = 7.2;
double cleanerPriceForLiter = 1.2;


/**
 * · Брой пакети химикали - цяло число в интервала [0...100]
 * · Брой пакети маркери - цяло число в интервала [0...100]
 * · Литри препарат за почистване на дъска - цяло число в интервала [0…50]
 * · Процент намаление - цяло число в интервала [0...100]
 */


int pensCount = int.Parse(Console.ReadLine());
int markersCount = int.Parse(Console.ReadLine());
int litersOfCleaner = int.Parse(Console.ReadLine());
int percentage = int.Parse(Console.ReadLine());


double pensTotal = pensCount * penPrice;
double markersTotal = markersCount * markerPrice;
double cleanerTotal = litersOfCleaner * cleanerPriceForLiter;


double total = pensTotal + markersTotal + cleanerTotal;

total = total - (total * ((double)percentage / 100));


/*
 * 2 3 4 25
 */


Console.WriteLine($"{total}");