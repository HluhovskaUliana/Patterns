using creational.builder.CharacterOptions;

namespace creational.builder;

public class Appearance
{
    public HairColorType HairColorType { get; set; }
    public SkinColorType SkinColorType { get; set; }
    public EyeColorType EyeColorType { get; set; }
    
    public override string ToString() => $"Hair: {HairColorType} | Skin: {SkinColorType} | Eye: {EyeColorType}";
}