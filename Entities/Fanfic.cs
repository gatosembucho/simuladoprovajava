namespace Simuladoprovajava.Entities;

public class Fanfic
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public int AuthorID { get; set; }
    public int ShelfID { get; set; }
    public User Author { get; set; }
    public Shelf Shelf { get; set; }
}