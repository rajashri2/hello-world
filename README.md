# hello-world
Hello world
Rajan Patil, Aundh, 1, Phone Cover, Rs 170, Cash
Mohit Gupta, Baner, 1, Samsung Battery, Rs 900, Credit Card
Rajan Patil, Aundh, 3, Samsung Battery, Rs 1000, Cash
Nina Kothari, Baner, 4, Earphones, Rs 500, Credit Card
T Sunitha, Shivajinagar, 5, Earphones, Rs 550, Credit Card
Rohan Gade, Aundh, 10, Motorola Battery, Rs 1000, Credit Card
Rajan Patil, Shivajinagar, 21, Earphones, Rs 550, Credit Card
Rajan Patil, Aundh, 22, USB Cable, Rs 150, UPI
Meena Kothari, Baner, 23, USB Cable, Rs 100, Cash
Nina Kothari, Baner, 24, USB Cable, Rs 200, UPI
Mohit Gupta, Baner, 25, USB Cable, Rs 150, UPI


The first column is customer name, the second column is store location, the third column is date (just day of the month is captured), the fourth column is product name, fifth is price, and sixth is payment type.


var result = data.GroupBy(l => l.Player)
             .Select(cl => new Foo()
             {
                Index = string.Join(", ", data.Where(d => d.Player == cl.Key).Select(d => d.Index).ToArray()),
                Player = cl.Key,
                Score = cl.Sum(c => c.Score)
             }).ToList();
