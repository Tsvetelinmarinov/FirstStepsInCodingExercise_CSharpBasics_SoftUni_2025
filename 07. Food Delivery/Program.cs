/**
 * 07. Food Delivery
 */


/**
 * • Пилешко меню – 10.35 лв.
 * • Меню с риба – 12.40 лв.
 * • Вегетарианско меню – 8.15 лв.
 */


double chickenMenu = 10.35;
double fishMenu = 12.4;
double veganMenu = 8.15;


double delivery = 2.5;


int chickenMenusCount = int.Parse(Console.ReadLine());
int fishMenusCount = int.Parse(Console.ReadLine());
int veganMenusCount = int.Parse(Console.ReadLine());


double total = (chickenMenusCount * chickenMenu) + (fishMenusCount * fishMenu) + (veganMenusCount * veganMenu);
double dessert = total * 0.2;


double finalCheck = total + dessert + delivery;


Console.WriteLine($"{finalCheck}");