using PCAD7_Project_MVC.Models;

namespace PCAD7_Project_MVC.Services
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
