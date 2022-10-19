using PCAD7_Assignment12_1.Models;

namespace PCAD7_Assignment12_1.Services
{
    //step2
    public interface IProduct
    {
        List<Product> GetProducts();
        Product GetProduct(int? id);
        void AddProduct(Product product);
        void DeleteProduct(int? id);
        void UpdateProduct(Product product);
        int GetMaxId();
        

    }
}
