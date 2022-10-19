using PCAD7_Assignment12_1.Models;

namespace PCAD7_Assignment12_1.Services
{
    public class DBCRUDRepository : IProduct
    {
        private ProductContext? _productContext;
        public DBCRUDRepository(ProductContext? productContext) // this productContext is like a presentation of our db on application side
        {
            _productContext = productContext;
        }

        public void AddProduct(Product product)
        {
            if (product.Department.ToString() == "Gi")
            {
                product.DeptId = 1;
            }
            if (product.Department.ToString() == "Books")
            {
                product.DeptId = 2;
            }
            if (product.Department.ToString() == "Mats")
            {
                product.DeptId = 3;
            }
            if (product.Department.ToString() == "Supplies")
            {
                product.DeptId = 4;
            }
            _productContext.Products.Add(product);
            _productContext.SaveChanges(); //data is saved and added to the db
        }

        public void DeleteProduct(int? id)
        {
            var pdct=_productContext.Products.Find(id);
            if(pdct !=null)
            {
                _productContext.Products.Remove(pdct);
                _productContext.SaveChanges();
            }
        }

        public Product GetProduct(int? id)
        {
            return _productContext.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return (_productContext.Products.ToList<Product>());
           // return new List<Product>();(_productContext.Products);
        }
        public int GetMaxId()
        {
            return _productContext.Products.Max(x => x.Id)+1;
        }

        public void UpdateProduct(Product product)
        {
            var pdct = _productContext.Products.Find(product.Id);
            if (pdct != null)
            {
                pdct.Id = product.Id;
                pdct.Name = product.Name;
                pdct.Description= product.Description;
                pdct.price= product.price;
                pdct.imageName= product.imageName;
                pdct.Department =product.Department;
                if (product.Department.ToString() == "Gi")
                {
                    pdct.DeptId = 1;
                }
                if (product.Department.ToString() == "Books")
                {
                    pdct.DeptId = 2;
                }
                if (product.Department.ToString() == "Mats")
                {
                    pdct.DeptId = 3;
                }
                if (product.Department.ToString() == "Supplies")
                {
                    pdct.DeptId = 4;
                }
                _productContext.SaveChanges();
            }
        }
    }
}
