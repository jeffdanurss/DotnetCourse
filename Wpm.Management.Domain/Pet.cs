namespace Wpm.Management.Domain;

public class Pet : Entity
{
    public string Name { get; init; }
    public int Age { get; init; }
    public string Color { get; set; }
    public int Weight { get; set; }
    public SexOfPet sexOfPet{ get; set; }
    public Pet(Guid id)
    {
        Id = id;
    }
}

public enum SexOfPet
{
    Male,
    Female
}
