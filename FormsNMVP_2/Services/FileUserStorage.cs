using System.Collections.Generic;
using System.IO;
using System.Linq;
using FormsNMVP.Models;
using Newtonsoft.Json;

namespace FormsNMVP.Services
{
    public class FileUserStorage : IUserStorage
    {
        private const string c_FileName = "users.json";
        private List<User> _users;

        public FileUserStorage()
        {
            LoadData();
        }

        public bool Add(User user)
        {
            if (_users.Any(x => x.Login == user.Login))
            {
                return false;
            }

            _users.Add(user);

            var result = SaveData();

            if (result)
            {
                return true;
            }

            _users.Remove(user);

            return false;
        }

        public bool RemoveByLogin(string login)
        {
            var result = GetUserByLogin(login);

            if (result != null)
            {
                _users.Remove(result);

                var success = SaveData();

                if (success)
                {
                    return true;
                }

                _users.Add(result);

                return true;
            }

            return false;
        }

        public User GetUserById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }

        public User GetUserByLogin(string login)
        {
            return _users.FirstOrDefault(x => x.Login == login);
        }

        public IReadOnlyList<User> GetAll()
        {
            return _users;
        }

        private bool SaveData()
        {
            try
            {
                var json = JsonConvert.SerializeObject(_users);

                File.WriteAllText(c_FileName, json);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private void LoadData()
        {
            try
            {
                var json = File.ReadAllText(c_FileName);

                _users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            catch
            {
                _users = new List<User>();
            }
        }
    }
}