using creational.builder.CharacterOptions;

namespace creational.builder;

public class Pet
{
    public PetType Type { get; set; }
    public string Name { get; set; }
    
    public override string ToString() => $"{Type}: {Name}";
}