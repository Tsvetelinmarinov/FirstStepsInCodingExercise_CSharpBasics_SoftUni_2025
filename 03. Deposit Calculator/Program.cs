/**
 * 03. Deposit Calculator
 */



/**
 * 1. Депозирана сума – реално число в интервала [100.00 … 10000.00]
 * 2. Срок на депозита (в месеци) – цяло число в интервала [1…12]
 * 3. Годишен лихвен процент – реално число в интервала [0.00 …100.00]
 */



double deposit = double.Parse(Console.ReadLine());
int depositPeriod = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());


percentage = percentage / 100;


double interest = deposit * percentage;


double interestForOneMount = interest / 12;


double finalSum = deposit + (depositPeriod * interestForOneMount);



//200 3 5.7


Console.WriteLine($"{finalSum}");