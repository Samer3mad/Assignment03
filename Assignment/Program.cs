namespace Assignment
{
    internal class Program
    {
        public class Book
        {
            public string ISBN { get; set; }
            public string Title { get; set; }
            public string[] Authors { get; set; }
            public DateTime PublicationDate { get; set; }
            public decimal Price { get; set; }
            public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
            {
                ISBN = _ISBN;
                Title = _Title;
                Authors = _Authors;
                PublicationDate = _PublicationDate;
                Price = _Price;
            }
            public override string ToString()
            {
                return $"ISBN: {ISBN}, Title: {Title}, Authors: {Authors}, Publication Date: {PublicationDate:yyyy-MM-dd}, Price: {Price}";
            }
        }
        public class BookFunctions
        {
            public static string GetTitle(Book B)
            {
                return $"Title: {B.Title}";
            }
            public static string GetAuthors(Book B)
            {
                return $"Authors: {string.Join(", ", B.Authors)}";
            }
            public static string GetPrice(Book B)
            {
                return $"Price: {B.Price}";

            }
        }
        public delegate string BookFunction(Book book);
        public class LibraryEngine
        {
            public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)

            {
                foreach (Book B in bList)
                {
                    Console.WriteLine(fPtr(B));
                }
            }
        }

        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("12345", "C# Programming", new[] { "John Doe", "Jane Smith" }, new DateTime(2021, 5, 1), 59.99m)
            };

            var fPtr1 = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, fPtr1);


            Func<Book, string> fPtr2 = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, fPtr2);


            Func<Book, string> GetISBN = delegate (Book B)
            {
                return $"ISBN: {B.ISBN}";
            };
            LibraryEngine.ProcessBooks(books, GetISBN);


            Func<Book, string> fPtrGetPublicationDate = B => $"Publication Date: {B.PublicationDate:yyyy-MM-dd}";
            LibraryEngine.ProcessBooks(books, fPtrGetPublicationDate);
        }
    }
}
