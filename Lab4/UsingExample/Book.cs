namespace KurgasovLabs.Lab4
{
    public class Book
    {
        public string Title { get; private set; }
        public string Description { get; private set; }

        public Book(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
