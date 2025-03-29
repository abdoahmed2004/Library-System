namespace library_system;

public class LibUser
{
    LibraryCard card;
    Usert user;
    public LibUser(Usert user, LibraryCard card)
    {
        this.user = user;
        this.card = card;
    }
}