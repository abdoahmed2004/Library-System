namespace library_system;

public class Library
{
     private List<Book> book;
     private List<Book> borrowedBooks;

    public Library()
     {
         book = new List<Book>();
         borrowedBooks = new List<Book>();
     }
     public void AddBook(Book book)
     {
         this.book.Add(book);
     }
    public void BorrowBook(Book book)
     {
            this.borrowedBooks.Add(book);
            this.book.Remove(book);
    }
    public void ReturnBook(Book book)
    {
        this.book.Add(book);
        this.borrowedBooks.Remove(book);
    }
    public void displayAvailableBooks()
    {
        Console.WriteLine("Available books are: ");
        foreach (var book in this.book)
        {
            Console.WriteLine(book.GetTitle());
        }
    }
   public void RemoveBook(Book book)
    {
        this.book.Remove(book);
    }
     
        
}