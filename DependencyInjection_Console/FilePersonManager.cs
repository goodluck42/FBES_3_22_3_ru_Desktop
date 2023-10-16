using System.Text.Json;

namespace DependencyInjection_Console;

public class FilePersonManager : IPersonManager
{
    private readonly List<Person> _persons;

    public FilePersonManager()
    {
        _persons = new List<Person>();
    }

    public void AddPerson(Person person)
    {
        var json = JsonSerializer.Serialize(person);

        File.WriteAllText("user.json", json);
        
        _persons.Add(person);
    }

    public int Count => _persons.Count;
}