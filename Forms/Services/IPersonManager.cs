using Forms.Models;

namespace Forms.Services
{
    public interface IPersonManager
    {
        bool RemoveById(int id);
        void Add(Person person);
        Person this[int index] { get; }
        int Count { get; }
    }
}