namespace DependencyInjection_Console;

public class PersonManager : IPersonManager
{
    private readonly List<Person> _persons;

    public PersonManager()
    {
        _persons = new List<Person>();
    }

    public void AddPerson(Person person)
    {
        _persons.Add(person);
    }

    public int Count => _persons.Count;
}