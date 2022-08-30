Meatballs meatballs  = new Meatballs();
Ramen ramen = new Ramen();

Console.WriteLine($"{meatballs.name} has {meatballs.protein} as protien and {meatballs.carbohydrates} as carbohydrates");
Console.WriteLine($"{ramen.name} has {ramen.protein} as protien and {ramen.carbohydrates} as carbohydrates");

Console.WriteLine("What grade do you give Meatballs?");
meatballs.grade = Console.ReadLine();

Console.WriteLine("What grade do you give Ramen?");
ramen.grade = Console.ReadLine();


Console.ReadLine();