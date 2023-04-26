namespace Todo.Models.Domain;

public class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public Person(int Id, string Name, string Email)
    {
        this.Id = Id;
        this.Name = Name;
        this.Email = Email;
    }
}