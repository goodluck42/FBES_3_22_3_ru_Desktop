using System.Collections.Generic;
using FormsNMVP.Models;

namespace FormsNMVP.Services
{
    public interface IProductStorage
    {
        bool Add(Product product);
        bool Update(Product product);
        bool Remove(Product product);
        bool RemoveById(int id);
        Product GetProductById(int id);

        IReadOnlyList<Product> GetAll();
    }
}