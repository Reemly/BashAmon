using System;

Evil e = new Evil();
Player p = new Player();

jinkies c = new jinkies();

while (e.health > 0 ) {

e.health -= 8;

Console.WriteLine("the hero attacks1111!");
Console.ReadLine();

Console.WriteLine($"evill!11 health: {e.health}");
Console.ReadLine();

if (e.health < 0) 
{
    Console.WriteLine("monser droppdd loot");
    Console.WriteLine("take? yes");
    string answer = Console.ReadLine();
    answer = answer.ToLower();

//kan va bättre att göra en while här, för annars så trycker man bara iväg dialogen tills programmet avslutas.
if (answer == "yes") {
    p.jinkies = true;
    
}




}



}

if (e.health < 0 && p.jinkies == true) {
    Console.WriteLine("u defeat evil!!");
    Console.ReadLine();
    Console.WriteLine("congralations hero");
    Console.ReadLine();
    Console.WriteLine("u also rihc now");
    Console.ReadLine();
    
}
