using System.Collections.Concurrent;

namespace Librarian
{
    public class Library
    {
        static ConcurrentDictionary<string, int> _keyValuePairs;

        public Library() 
        {
            _keyValuePairs = new ConcurrentDictionary<string, int>();
        }

        public void AddBook(string name)
        {
            _keyValuePairs.TryAdd(name, 0);
        }

        public void GetLibrary()
        {
            foreach (var book in _keyValuePairs)
            {
                Console.WriteLine(book.Key + " - " + book.Value + "%");
            }
        }

        public Task RunTask(CancellationToken token)
        {
            return Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    foreach (var book in _keyValuePairs)
                    {
                        var currentValue = book.Value;
                        if (book.Value < 100)
                        {
                            _keyValuePairs.TryUpdate(book.Key, currentValue + 1, currentValue);
                        }
                        else
                        {
                            _keyValuePairs.TryRemove(book.Key, out _);
                        }
                    }

                    await Task.Delay(1000);
                }
            }, token);
        }
    }
}
