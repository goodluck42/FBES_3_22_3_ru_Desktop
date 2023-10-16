namespace DependencyInjection_Console;

public interface IPersonManager
{
    void AddPerson(Person person);
    public int Count { get; }
}