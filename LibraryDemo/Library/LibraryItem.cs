namespace Library
{
    public abstract class LibraryItem
    {
        public string Title { get; set; }
        public int Year { get; set; }

        protected LibraryItem(string Title, int year)
        {
            this.Title = Title;
            Year = year;
        }

        public abstract string GetID();

        public abstract string GetDetails();

        public override string ToString() => GetDetails();
    }

    public class Book : LibraryItem
    {
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, int year, string author, string isbn) : base(title, year)
        {
            Author = author;
            ISBN = isbn;
        }

        public override string GetID() => ISBN;

        public override string GetDetails()
        {
            return $"Book: {Title} ({Year}) by {Author}";
        }
    }

    public class Magazine : LibraryItem
    {
        public int Issue { get; set; }
        public string ISSN { get; set; }

        public Magazine(string title, int year, int issue, string iSSN) : base(title, year)
        {
            Issue = issue;
            ISSN = iSSN;
        }

        public override string GetDetails()
        {
            return $"Magazine: {Title} ({Year}) Issue {Issue}";
        }

        public override string GetID()
        {
            return $"{ISSN}-{Issue}";
        }
    }

}
