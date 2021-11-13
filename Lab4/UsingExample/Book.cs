namespace KurgasovLabs.Lab4
{
    public class Book
    {
        public Book(string title, string description, decimal price, int count)
        {
            Title = title;
            Description = description;
            Price = price;
            Count = count;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Count { get; set; }

        public decimal Sell()
        {
            if (Count > 0)
            {
                Count--;
                return Price;
            }
            return 0;
        }
    }
}
