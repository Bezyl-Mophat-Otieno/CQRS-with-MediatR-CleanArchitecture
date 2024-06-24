using MediatR;

namespace clean_architecture_using_mediatR;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, Product?>
{
    public Task<Product?> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        Product? product = InMemoryDB.GetProduct(request.Id);
        return Task.FromResult(product);
    }
}
