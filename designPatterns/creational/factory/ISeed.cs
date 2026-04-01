namespace creational.factory;

public interface ISeed
{
    string Name { get; }
    int GrowthTime { get; }
    void Plant();
}