using creational.builder.CharacterOptions;

namespace creational.builder;

public class Character
{
    public string Name { get; set; }
    public string FarmName { get; set; }
    public string FavoriteItem { get; set; }
    public CharacterGender Gender { get; set; }
    public Appearance Appearance { get; set; }
    public Pet Pet { get; set; }
    
    public override string ToString() => 
        $"Name: {Name}\n" +
        $"Farm: {FarmName}\n" +
        $"Favorite Item: {FavoriteItem}\n" +
        $"Gender: {Gender}\n" +
        $"Appearance: {Appearance}\n" +
        $"Pet: {Pet}\n";
}