using TheHouseThatJackBuilt;

Console.WriteLine("Дом, который построил Джек");

Part1 part1 = new Part1();
Part2 part2 = new Part2(part1.AddPart());
Part3 part3 = new Part3(part2.AddPart(part1.Poem));
Part4 part4 = new Part4(part3.AddPart(part2.Poem));
Part5 part5 = new Part5(part4.AddPart(part3.Poem));
Part6 part6 = new Part6(part5.AddPart(part4.Poem));
Part7 part7 = new Part7(part6.AddPart(part5.Poem));
Part8 part8 = new Part8(part7.AddPart(part6.Poem));
Part9 part9 = new Part9(part8.AddPart(part7.Poem));

Console.WriteLine($"{String.Join("\r\n", part9.AddPart(part8.Poem))}");

Console.WriteLine($"\r\nСамуил Маршак");

Console.WriteLine("\r\n\r\n\r\nИ отдельно по частам\r\n");
Console.WriteLine("\r\nЧасть 1:");
Console.WriteLine($"{String.Join("\r\n", part1.Poem)}");
Console.WriteLine("\r\nЧасть 2:");
Console.WriteLine($"{String.Join("\r\n", part2.Poem)}");
Console.WriteLine("\r\nЧасть 3:");
Console.WriteLine($"{String.Join("\r\n", part3.Poem)}");
Console.WriteLine("\r\nЧасть 4:");
Console.WriteLine($"{String.Join("\r\n", part4.Poem)}");
Console.WriteLine("\r\nЧасть 5:");
Console.WriteLine($"{String.Join("\r\n", part5.Poem)}");
Console.WriteLine("\r\nЧасть 6:");
Console.WriteLine($"{String.Join("\r\n", part6.Poem)}");
Console.WriteLine("\r\nЧасть 7:");
Console.WriteLine($"{String.Join("\r\n", part7.Poem)}");
Console.WriteLine("\r\nЧасть 8:");
Console.WriteLine($"{String.Join("\r\n", part8.Poem)}");
Console.WriteLine("\r\nЧасть 9, финишная:");
Console.WriteLine($"{String.Join("\r\n", part9.Poem)}");