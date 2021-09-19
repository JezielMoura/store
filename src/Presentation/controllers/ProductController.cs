using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Mobnet.Store.Application.Products.Commands;
using Mobnet.Store.Application.Products.Queries;
using Mobnet.Store.Domain.Entities;
#nullable disable
namespace Mobnet.Store.Presentaion.Controllers;

[ApiController]
[Route("/api/product/")]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
        => _mediator = mediator;

    [HttpGet]
    public async Task<IEnumerable<Product>> GetAll()
        => await _mediator.Send(new GetAllProducts());

    [HttpGet("{code}")]
    public async Task<Product> Get(long code)
    {
        return await Task.FromResult(SeedProducts().Find(c => c.Code == code));
    }

    [HttpGet("search/{term}")]
    public async Task<IEnumerable<Product>> Search(string term)
    {
        return await Task.FromResult(SeedProducts().Where(c => c.Name.Contains(term)).ToList());
    }
        //=> await _mediator.Send(new GetProductById {Code = code });

    [HttpPost]
    public async Task Add([FromBody] AddProduct command)
        => await _mediator.Send(command);

    [HttpPut]
    public async Task Edit([FromBody] EditProduct command)
        => await _mediator.Send(command);

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id)
        => await _mediator.Send(new DeleteProduct(id));

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