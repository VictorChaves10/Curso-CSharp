
using ExStringBuilder.Entities;

Coment1 c1 = new Coment1("Have a nice trip!");
Coment1 c2 = new Coment1("Wow that's awesome!");

Post p1 = new Post (

    DateTime.Now,
    "Traveling to New Zealand",
    "I'm going to visit this wonderful country!",
    12
);

p1.AddComment(c1);
p1.AddComment(c2);

Coment1 c3 = new Coment1("Good Night");
Coment1 c4 = new Coment1("May the Force be with you");

Post p2 = new Post(
    DateTime.Now,
    "Good Nitght guys",
    "See you tomorrow",
    5
);

p2.AddComment(c3);
p2.AddComment(c4);

Console.WriteLine(p1);
Console.WriteLine();
Console.WriteLine(p2);