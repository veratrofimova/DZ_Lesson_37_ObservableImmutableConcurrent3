using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularCustomer
{
    public class Customer 
    {
        private string _name;
        private Shop _shop;

        public Customer(string name)
        {
            _name = name;
        }

        public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    var item = e.NewItems[0] as Item;
                    Console.WriteLine($"{_name}, появился товар {item.Name} c ИД: {item.ID}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    item = e.OldItems[0] as Item;
                    Console.WriteLine($"{_name}, товар {item.Name} удален");
                    break;
            }
        }
        public void Subscribe(Shop shop)
        {
            _shop = shop;
            _shop.Items.CollectionChanged += OnItemChanged;
            Console.WriteLine($"{_name} оформил подписку");
        }

        /*
метод OnItemChanged, который будет срабатывать, когда список товаров в магазине обновился. 
В этом методе надо выводить в консоль информацию о том, 
какое именно изменение произошло (добавлен товар с таким-то названием 
и таким-то идентификатором / удален такой-то товар).
*/
    }
}
