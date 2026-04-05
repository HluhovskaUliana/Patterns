using creational.builder.CharacterOptions;

namespace creational.builder;

public class CharacterBuilder
{
    private Character _character  = new Character
    {
        Name         = "Farmer",        
        FarmName     = "My Farm",      
        FavoriteItem = "Pizza",         
        Gender       = CharacterGender.Male
    };
    
    private Appearance _appearance = new Appearance
    {
        HairColorType = HairColorType.Purple
    };
    
    private Pet _pet = new Pet
    {
        Type = PetType.Dog,
        Name = "Bob"
    };
    
    
    public CharacterBuilder SetName(string name)
    {
        _character.Name = name;
        return this;
    }

    public CharacterBuilder SetFarmName(string farmName)
    {
        _character.FarmName = farmName;
        return this;
    }

    public CharacterBuilder SetFavoriteItem(string item)
    {
        _character.FavoriteItem = item;
        return this;
    }

    public CharacterBuilder SetGender(CharacterGender gender)
    {
        _character.Gender = gender;
        return this;
    }

    // Зовнішність
    public CharacterBuilder SetHairColor(HairColorType color)
    {
        _appearance.HairColorType = color;
        return this;
    }

    public CharacterBuilder SetSkinColor(SkinColorType color)
    {
        _appearance.SkinColorType = color;
        return this;
    }

    public CharacterBuilder SetEyeColor(EyeColorType color)
    {
        _appearance.EyeColorType = color;
        return this;
    }

    // Улюбленець
    public CharacterBuilder SetPetType(PetType type)
    {
        _pet.Type = type;
        return this;
    }

    public CharacterBuilder SetPetName(string name)
    {
        _pet.Name = name;
        return this;
    }

    public Character Build()
    {
        _character.Appearance = _appearance;
        _character.Pet        = _pet;
        return _character;
    }
}