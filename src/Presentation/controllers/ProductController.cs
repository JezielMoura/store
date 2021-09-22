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
        => await _mediator.Send(new GetProductById(){Code = code});

    [HttpGet("search/{term}")]
    public async Task<IEnumerable<Product>> Search(string term)
        => await _mediator.Send(new GetProductByName(){ Name = term});

    [HttpPost]
    public async Task Add([FromBody] AddProduct command)
        => await _mediator.Send(command);

    [HttpPut]
    public async Task Edit([FromBody] EditProduct command)
        => await _mediator.Send(command);

    [HttpGet("delete/{code}")]
    public async Task Delete([FromRoute] long code)
        => await _mediator.Send(new DeleteProduct(code));
        
}