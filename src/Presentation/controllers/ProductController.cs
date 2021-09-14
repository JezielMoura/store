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
    public async Task<ActionResult<Product>> Get(long code)
        => await _mediator.Send(new GetProductById {Code = code });

    [HttpPost]
    public async Task Add([FromBody] AddProduct command)
        => await _mediator.Send(command);

    [HttpPut]
    public async Task Edit([FromBody] EditProduct command)
        => await _mediator.Send(command);

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id)
        => await _mediator.Send(new DeleteProduct(id));
}