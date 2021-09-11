using Mobnet.Store.Application.Orders.Commands;
using Mobnet.Store.Application.Orders.Queries;

namespace Mobnet.Store.Presentaion.Controllers;

[ApiController]
[Route("/api/order")]
public class OrderController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrderController(IMediator mediator)
        => _mediator = mediator;

    [HttpGet]
    public async Task<IEnumerable<Order>> GetAll()
        => await _mediator.Send(new GetAllOrders());

    [HttpGet("{id}")]
    public async Task<Order> Get(Guid id)
        => await _mediator.Send(new GetOrderById(id));

    [HttpPost]
    public async Task Add(ProcessOrder command)
        => await _mediator.Send(command);

    [HttpPut]
    public async Task Edit(ChangeOrder command)
        => await _mediator.Send(command);

    [HttpDelete]
    public async Task Delete(DeleteOrder command)
        => await _mediator.Send(command);
}