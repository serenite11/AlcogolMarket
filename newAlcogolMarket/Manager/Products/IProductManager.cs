﻿namespace newAlcogolMarket.Manager.Products
{
    public interface IProductManager
    {
        Task<List<Product>> GetAll();
        Task Add(Product product);
        Task Delete(int id);
        Task Update(Product product);
        Task<List<Product>> Filter(string name);
        Product Get(Product product);
        Task<List<Product>> GetAllByCategory(string categoryName);
    }
}
