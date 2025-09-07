namespace Simuladoprovajava.Entities;

public class Shelf
{
    public int ID { get; set; }
    public string Title { get; set; }
    public DateTime LastMod { get; set; }
    public int OwnerID { get; set; }
    public User Owner { get; set; }
    public ICollection<Fanfic> Fanfics = [];
}