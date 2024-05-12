using ASP.NETCoreDependencyInjection.Models.Northwind;
using ASP.NETCoreDependencyInjection.Repositories.Abstracts;

namespace ASP.NETCoreDependencyInjection.Repositories.Concretes
{
    public class ProductService : IProductService

        
    {
        private readonly NorthwndContext _northwndContext;

        public ProductService(NorthwndContext northwndContext) 
        {
            _northwndContext = northwndContext;
        }
       

        public void CreateProduct(Product product)
        {
            _northwndContext.Products.Add(product);
            _northwndContext.SaveChanges();
        }

       

        public void DeleteProduct(int id)
        {
            _northwndContext.Remove(id);
            _northwndContext.SaveChanges();
        }

        

        public List<Product> GetAllProduct()
        {
            return _northwndContext.Products.ToList();
        }

        

        public void UpdateProduct(Product updated)
        {
            var updatedProduct=_northwndContext.Products.Find(updated.ProductId);
            _northwndContext.Entry(updatedProduct).CurrentValues.SetValues(updated);
            _northwndContext.SaveChanges() ;
        }
    }
}
