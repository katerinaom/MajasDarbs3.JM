using MajasDarbs3.JM;

Phone samsung = new Phone();

samsung.Brand = "Samsung";
samsung.Model = "Galaxy";
samsung.Size = 5;

string samsungBrand = samsung.Brand;
Console.WriteLine($"I have created with name: {samsungBrand}");

string samsungModel = samsung.Model;
Console.WriteLine($"My Model is: {samsungModel}");

double samsungSize = samsung.Size;
Console.WriteLine($"My size is: {samsungSize}");

Console.WriteLine($"{samsungBrand} can call and send messages :) ");


Console.WriteLine();
Console.WriteLine("===============================");
Console.WriteLine();

Car audi = new Car();
audi.Brand = "Audi";
audi.NumberPlate = "LV - 4444";
audi.Speed = 90;

audi.StartToDrive();
Console.WriteLine("Let's go 90! ");

audi.GoFaster();
Console.WriteLine("Wow! We are Faster! ");

audi.Beep();
Console.WriteLine("Yoohoooo !!!! ");

Console.WriteLine("Better go slower! ");
audi.SlowDown();
audi.Stop();

Console.WriteLine("Thanks for nice driving! ");



Console.WriteLine();
Console.WriteLine("===============================");
Console.WriteLine();

Product bed = new Product();

bed.Name = "Bed";
bed.Buy();

Console.WriteLine($"What is the size of the {bed.Name}? " );
bed.Size();


