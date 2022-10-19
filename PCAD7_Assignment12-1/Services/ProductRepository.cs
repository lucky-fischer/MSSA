using PCAD7_Assignment12_1.Models;

namespace PCAD7_Assignment12_1.Services
{
    //Step 3.
    public class ProductRepository : IProduct
    {
        private List<Product> products;
        public ProductRepository()
        {
            products = new List<Product>();
            products.Add(new Product() { Id = 1, Name = "White Gi", Description = "white BJJ uniform", price = 74.99f, imageName = "images.jpg" });
            products.Add(new Product() { Id = 2, Name = "BJJ Mats", Description = "BJJ roll out mats", price = 124.99f, imageName = "bjjMats.jpg" });
            products.Add(new Product() { Id = 3, Name = "Finger Tape", Description = "Tape to protect fingers", price = 4.99f, imageName = "fingerTape.jpg" });
            products.Add(new Product() { Id = 4, Name = "BJJ Soap", Description = "After training soap", price = 9.99f, imageName = "BJJSoap.jpg" });

        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(int? id)
        {
            var pdct = products.Find(x=>x.Id==id);
            if (pdct != null)
            products.Remove(pdct);
        }

        public int GetMaxId()
        {
            int id=products.Max(x=>x.Id);
            return id+1;
        }

        public Product GetProduct(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return products.Find(x => x.Id == id);
            }
        }
        public List<Product> GetProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
            var pdct = products.Find(x => x.Id == product.Id);
            if (pdct != null)
            {
                pdct.Id=product.Id;
                pdct.Name = product.Name;
                pdct.Description = product.Description;
                pdct.price = product.price;
                pdct.Department=product.Department;
                pdct.imageName=product.imageName;
            }
        }
    }
}
