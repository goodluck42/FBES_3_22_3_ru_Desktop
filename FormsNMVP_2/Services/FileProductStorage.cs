using System.Collections.Generic;
using System.IO;
using System.Linq;
using FormsNMVP.Models;
using Newtonsoft.Json;

namespace FormsNMVP.Services
{
    public class FileProductStorage : IProductStorage
    {
        private const string c_FileName = "products.json";

        private List<Product> _products;

        public FileProductStorage()
        {
            LoadData();
        }

        public bool Add(Product product)
        {
            _products.Add(product);

            SaveData();

            return true;
        }

        public bool Update(Product product)
        {
            return true;
        }

        public bool Remove(Product product)
        {
            var result = _products.Remove(product);

            if (result)
            {
                SaveData();

                return true;
            }

            return false;
        }

        public bool RemoveById(int id)
        {
            var product = GetProductById(id);

            if (product != null)
            {
                _products.Remove(product);

                SaveData();

                return true;
            }

            return false;
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public IReadOnlyList<Product> GetAll()
        {
            return _products;
        }

        private bool SaveData()
        {
            try
            {
                var json = JsonConvert.SerializeObject(_products);

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

                _products = JsonConvert.DeserializeObject<List<Product>>(json);
            }
            catch
            {
                _products = new List<Product>();
            }
        }
    }
}