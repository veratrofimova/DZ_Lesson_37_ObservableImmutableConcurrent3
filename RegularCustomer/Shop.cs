using System.Collections.ObjectModel;

namespace RegularCustomer
{
    public class Shop 
    {
        public ObservableCollection<Item> Items = new ObservableCollection<Item>();

        public void Add(Item items)
        {
            Items.Add(items);
        }

        public void Remove(int id)
        {
            if (Items == null || Items.Count == 0)
                NoItems();

            foreach (var item in Items)
            {
                if (id == item.ID)
                {
                    Items.Remove(item);
                    return;
                }
                else
                {
                    NoItems();
                }
            }            
        }

        private void NoItems()
        {
            var ex = new Exception("Товар отстутствует в магазине");
            throw ex;
        }
    }
}
