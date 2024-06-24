using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace clean_architecture_using_mediatR;

[ApiController]
[Route("api/[controller]")]
public class ProductsController:ControllerBase
{
    private readonly IMediator _mediator;
    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> AddProduct([FromBody] Product product)
    {
        await _mediator.Send(new AddProductCommand { Product = product });
        return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
    }
    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var products = await _mediator.Send(new GetProductsQuery());
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProduct(int id)
    {
        var product = await _mediator.Send(new GetProductQuery { Id = id });
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product product)
    {
        if (id != product.Id)
        {
            return BadRequest();
        }
        await _mediator.Send(new UpdateProductCommand { Product = product , Id = id});
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        await _mediator.Send(new DeleteProductCommand { Id = id });
        return NoContent();
    }



}
