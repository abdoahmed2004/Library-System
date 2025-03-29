namespace library_system;

class Program
{
    static void Main(string[] args)
    {
        Usert user = new Usert("John Doe");
        LibraryCard card = new LibraryCard(1234);
        LibUser libUser = new LibUser(user, card);
        Book book = new Book("The Hobbit", "J.R.R. Tolkien", 1937);
        Book book1 = new Book("popy", "bob", 1939);
        Book book2 = new Book("The sea", "KOKo ", 1980);
        Library library = new Library();
        library.AddBook(book);
        library.AddBook(book1);
        library.AddBook(book2);
        library.displayAvailableBooks();
        library.BorrowBook(book);
        library.displayAvailableBooks();
        library.ReturnBook(book);
        library.displayAvailableBooks();
        
        
    }
}