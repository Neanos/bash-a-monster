Player thePlayer  = new Player();
Enemy theEnemy = new Enemy();

Console.WriteLine($"{thePlayer.name} has {thePlayer.health} health points");
Console.WriteLine($"{theEnemy.name} has {theEnemy.health} health points");

Console.WriteLine("Attack!!!");
theEnemy.health -= 10;

Console.WriteLine($"{theEnemy.name} now has {theEnemy.health} health points");

Console.ReadLine();