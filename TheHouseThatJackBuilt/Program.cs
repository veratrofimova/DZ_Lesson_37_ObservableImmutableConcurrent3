using TheHouseThatJackBuilt;

Console.WriteLine("Дом, который построил Джек\r\n");

Part1 part1 = new Part1();
Part2 part2 = new Part2();
Part3 part3 = new Part3();
Part4 part4 = new Part4();
Part5 part5 = new Part5();
Part6 part6 = new Part6();
Part7 part7 = new Part7();
Part8 part8 = new Part8();
Part9 part9 = new Part9();

part1.AddPart();
part2.AddPart(part1.Poem);
part3.AddPart(part2.Poem);
part4.AddPart(part3.Poem);
part5.AddPart(part4.Poem);
part6.AddPart(part5.Poem);
part7.AddPart(part6.Poem);
part8.AddPart(part7.Poem);
part9.AddPart(part8.Poem);

Console.WriteLine($"{String.Join("\r\n", part9.Poem)}");

Console.WriteLine($"Самуил Маршак");

Console.WriteLine("\r\n\r\n\r\nИ отдельно по частам\r\n");
Console.WriteLine("\r\nЧасть 1:");
Console.WriteLine($"{String.Join("\r\n", part1.NewPart)}");
Console.WriteLine("\r\nЧасть 2:");
Console.WriteLine($"{String.Join("\r\n", part2.NewPart)}");
Console.WriteLine("\r\nЧасть 3:");
Console.WriteLine($"{String.Join("\r\n", part3.NewPart)}");
Console.WriteLine("\r\nЧасть 4:");
Console.WriteLine($"{String.Join("\r\n", part4.NewPart)}");
Console.WriteLine("\r\nЧасть 5:");
Console.WriteLine($"{String.Join("\r\n", part5.NewPart)}");
Console.WriteLine("\r\nЧасть 6:");
Console.WriteLine($"{String.Join("\r\n", part6.NewPart)}");
Console.WriteLine("\r\nЧасть 7:");
Console.WriteLine($"{String.Join("\r\n", part7.NewPart)}");
Console.WriteLine("\r\nЧасть 8:");
Console.WriteLine($"{String.Join("\r\n", part8.NewPart)}");
Console.WriteLine("\r\nЧасть 9:");
Console.WriteLine($"{String.Join("\r\n", part9.NewPart)}");