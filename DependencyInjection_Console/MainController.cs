namespace DependencyInjection_Console;

public class MainController
{
    private IPersonManager? _currentManager;
    private IEnumerable<IPersonManager> _managers;
    
    // Constructor Injection
    public MainController(IEnumerable<IPersonManager> managers)
    {
        _managers = managers;
    }
    
    public void ChooseManager()
    {
        var choice = int.Parse(Console.ReadLine()!);

        switch (choice)
        {
            case 1:
                _currentManager = _managers.ElementAt(0); // PersonManager
                break;
            case 2:
                _currentManager = _managers.ElementAt(1); // FilePersonManager
                break;
            default:
                Console.WriteLine("Managers is not available");
                break;
        }
    }

    public void AddPerson()
    {
        if (_currentManager is null)
        {
            Console.WriteLine("Manager is not set.");
            return;
        }

        int id = int.Parse(Console.ReadLine()!);

        var person = new Person()
        {
            Id = id
        };

        _currentManager.AddPerson(person);
    }
}