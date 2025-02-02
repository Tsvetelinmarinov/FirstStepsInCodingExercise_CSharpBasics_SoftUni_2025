/**
 * 06. Repainting
 */



/**
 * · Предпазен найлон - 1.50 лв. за кв. метър
 * · Боя - 14.50 лв. за литър
 * · Разредител за боя - 5.00 лв. за литър
 * 
 * 1. Необходимо количество найлон (в кв.м.) - цяло число в интервала [1... 100]
 * 2. Необходимо количество боя (в литри) - цяло число в интервала [1…100]
 * 3. Количество разредител (в литри) - цяло число в интервала [1…30]
 * 4. Часовете, за които майсторите ще свършат работата - цяло число в интервала [1…9]
 * 
 * 
 * · "{сумата на всички разходи}"
 */


double nailonPriceForSquareMeter = 1.5;
double paintPriceForOneLiter = 14.5;
double diluentPriceForOneLiter = 5.0;


int nailonInSquareMeters = int.Parse(Console.ReadLine());
int litersPaintNeeded = int.Parse(Console.ReadLine());
int litersDiluentNeeded = int.Parse(Console.ReadLine());
int workingHours = int.Parse(Console.ReadLine());



nailonInSquareMeters += 2;
double totalLitersOfPaint = litersPaintNeeded + (litersPaintNeeded * 0.1);


double bagPrice = 0.4;


double totalForNailon = nailonInSquareMeters * nailonPriceForSquareMeter;
double totalForPaint = totalLitersOfPaint * paintPriceForOneLiter;
double totalDiluent = litersDiluentNeeded * diluentPriceForOneLiter;


double totalSum = totalForNailon + totalForPaint + totalDiluent + bagPrice ;


double mastersPaymentForOneHour = totalSum * 0.3;


double mastersPayment = mastersPaymentForOneHour * workingHours;

double finalSum = mastersPayment + totalSum;


Console.WriteLine($"{finalSum}");