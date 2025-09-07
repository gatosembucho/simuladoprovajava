namespace Simuladoprovajava.Entities;

public class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Description { get; set; }
    public DateTime Entry { get; set; }
    public ICollection<Fanfic> Fanfics { get; set; } = [];
    public ICollection<Shelf> Shelves { get; set; } = [];
}
