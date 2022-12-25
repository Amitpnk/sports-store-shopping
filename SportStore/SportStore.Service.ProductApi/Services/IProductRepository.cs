using SportStore.Service.ProductApi.Entities;
using SportStore.Service.ProductApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Service.ProductApi.Services
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProduct(string id);
        Task<ProductDto> CreateProduct(ProductDto product);
        Task<bool> UpdateProduct(ProductDto product);
        Task<bool> DeleteProduct(string id);
    }
}
