namespace creational.prototype;

public class GameState : IPrototype
{
    public string PlayerName { get; set; }
    public int    Health     { get; set; }
    public int    Gold       { get; set; }
    public int    Day        { get; set; }

    public GameState(string playerName, int health, int gold, int day)
    {
        PlayerName = playerName;
        Health     = health;
        Gold       = gold;
        Day        = day;
    }

    public IPrototype DoClone()
    {
        return new GameState(PlayerName, Health, Gold, Day);
    }

    public override string ToString() =>
        $"Player: {PlayerName} | HP: {Health} | Gold: {Gold} | Day: {Day}";
}