/**
 * 08. Basketball Equipment
 */


/**
 * • Баскетболни кецове – цената им е 40% по-малка от таксата за една година
 * • Баскетболен екип – цената му е 20% по-евтина от тази на кецовете
 * • Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
 * • Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка
 */



int paymentPerYear = int.Parse(Console.ReadLine());


double kedsPrice = paymentPerYear - paymentPerYear * 0.4;
double topPrice = kedsPrice - kedsPrice * 0.2;
double ballPrice = topPrice / 4;
double otherStuff = ballPrice / 5;


double totalPrice = paymentPerYear + kedsPrice + topPrice + ballPrice + otherStuff;


Console.WriteLine($"{totalPrice}");