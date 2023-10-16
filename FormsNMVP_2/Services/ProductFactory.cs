using FormsNMVP.Models;

namespace FormsNMVP.Services
{
    public class ProductFactory
    {
        public ProductFactory()
        {
            _lastId = 1;
        }

        public Product Create()
        {
            var product = new Product()
            {
                Id = _lastId++
            };

            return product;
        }

        private int _lastId;
    }
}