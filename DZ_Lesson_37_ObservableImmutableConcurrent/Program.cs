using Librarian;

Console.WriteLine("Добро пожаловать в программу \"Библиотекарь\"");

var library = new Library();
CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
CancellationToken token = cancelTokenSource.Token;
Task task = library.RunTask(token);

try
{
    string? common = null;

    do
    {
        Console.WriteLine("\r\n1 - добавить книгу; 2 - вывести список непрочитанного; 3 - выйти");
        common = Console.ReadLine();

        switch (common)
        {
            case "1":
                Console.WriteLine("Введите название книги:");
                string input = Console.ReadLine();

                library.AddBook(input);
                continue;
            case "2":
                library.GetLibrary();
                continue;
            case "3":
                cancelTokenSource.Cancel();
                cancelTokenSource.Dispose();
                break;
        }
    }
    while (common != "3");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Программа завершена");

