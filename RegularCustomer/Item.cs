namespace RegularCustomer
{
    public class Item
    {
        private int _id;
        public int ID => _id;

        private string _name;
        public string Name => _name;

        public Item(int id, string name)
        {
            _id = id;
            _name = name;
        }
    }
}
