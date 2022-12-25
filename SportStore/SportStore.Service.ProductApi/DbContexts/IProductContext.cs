using MongoDB.Driver;
using SportStore.Service.ProductApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStore.Service.ProductApi.DbContexts
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }

       
    }
}
