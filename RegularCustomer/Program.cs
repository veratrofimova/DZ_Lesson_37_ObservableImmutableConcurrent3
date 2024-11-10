using RegularCustomer;

Console.WriteLine("Добро пожаловать в программу \"Постоянный покупатель\"");

int count = 0;

var shop = new Shop();
var customer = new Customer("Мартин");
customer.Subscribe(shop);

try
{
    string? common = null;

    do
    {
        Console.WriteLine("\r\nДля добавления товара введите A, для удаления - D, для выхода - X");
        common = Console.ReadLine();

        switch (common)
        {
            case "A":
                Console.WriteLine("Введите наименование товара для добавления");
                string input = Console.ReadLine();

                shop.Add(new Item(count, input + " от " + DateTime.Now));
                count++;
                break;
            case "D":
                try
                {
                    Console.WriteLine("Введите ID товара для удаления");
                    int.TryParse(Console.ReadLine(), out int id);

                    shop.Remove(id);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите число");
                }
                break;
        }
    }
    while (common != "X");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Программа завершена");
