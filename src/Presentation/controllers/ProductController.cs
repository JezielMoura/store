namespace Mobnet.Store.Presentaion.Controllers;

[ApiController]
[Route("/api/product")]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
        => _mediator = mediator;

    [HttpGet]
    public async Task<IEnumerable<Product>> GetAll()
        => await _mediator.Send(new GetAllProducts());

    [HttpGet("{id}")]
    public async Task<Product> Get([FromRoute] Guid id)
        => await _mediator.Send(new GetProductById {Id = id });

    [HttpPost]
    public async Task Add([FromRoute] AddProduct command)
        => await _mediator.Send(command);

    [HttpPut]
    public async Task Edit([FromRoute] EditProduct command)
        => await _mediator.Send(command);

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id)
        => await _mediator.Send(new DeleteProduct(id));
}