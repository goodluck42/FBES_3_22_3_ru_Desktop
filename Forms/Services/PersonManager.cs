using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Forms.Models;

namespace Forms.Services
{
    public class DbPersonManager : IPersonManager
    {
        public bool RemoveById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Person person)
        {
            throw new System.NotImplementedException();
        }

        public Person this[int index] => throw new System.NotImplementedException();

        public int Count { get; }
    }
    public class PersonManager : IPersonManager
    {
        private List<Person> _persons;

        public PersonManager()
        {
            _persons = new List<Person>();
            //MessageBox.Show("PersonManager");
        }
        
        public bool RemoveById(int id)
        {
            var result = _persons.FirstOrDefault(x => x.Id == id);

            if (result == null)
            {
                return false;
            }

            _persons.Remove(result);

            return true;
        }

        public void Add(Person person)
        {
            if (_persons.Any(x => x.Id == person.Id))
            {
                return;
            }
            
            _persons.Add(person);
        }

        public Person this[int index] => _persons[index];

        public int Count => _persons.Count; //public int Count { get; }
    }
}