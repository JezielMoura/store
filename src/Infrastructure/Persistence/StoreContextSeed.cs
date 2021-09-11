using Mobnet.Store.Domain.Entities;
using System;

namespace Mobnet.Store.Infrastructure.Persistence;

public static class StoreContextSeed
{
    public static List<Product> SeedProducts()
    {
        var products = new List<Product>();

        products.Add(
            new Product(Guid.NewGuid(), 1, "Biquine", "", 4, 2, 38.90M, 99.90M, 10));

        products.Add(
                new Product(Guid.NewGuid(), 2, "Boné Nike", "Preto", 5, 3, 24.90M, 12, 10));

        products.Add(
            new Product(Guid.NewGuid(), 3, "Snorkel", "", 8, 4, 29.90M, 14M, 10));

        products.Add(
            new Product(Guid.NewGuid(), 4, "Chapeu", "", 4, 2, 12M, 27.90M, 10));

        products.Add(
            new Product(Guid.NewGuid(), 5, "Saída de Praia", "", 4, 2, 33M, 78.90M, 10));

        products.Add(
            new Product(Guid.NewGuid(), 6, "Canga", "", 4, 2, 40M, 99.90M, 10));

        products.Add(
            new Product(Guid.NewGuid(), 7, "Óculos'", "", 10, 5, 8M, 19.90M, 10));

        products.Add(
            new Product(Guid.NewGuid(), 8, "Namoradeira", "Pequena", 4, 2, 12M, 24.90M, 10));

        products.Add(
            new Product(Guid.NewGuid(), 9, "Sunga", "M", 10, 4, 17M, 29.90M, 10));

        products.Add(
            new Product(Guid.NewGuid(), 10, "UV", "M", 18, 10, 23M, 59.90M, 10));

        return products;
    }
}