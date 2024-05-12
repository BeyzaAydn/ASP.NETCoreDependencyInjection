using ASP.NETCoreDependencyInjection.Models.Northwind;

namespace ASP.NETCoreDependencyInjection.Repositories.Abstracts
{
    public interface IProductService
    {

        //Read
        List<Product> GetAllProduct();

        //Create
        void CreateProduct(Product product);


        

        //Update
        void UpdateProduct(Product updated);

        //Delete
        void DeleteProduct(int id);


    }
}
