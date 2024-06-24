using MediatR;

namespace clean_architecture_using_mediatR;

public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<Product>>
{
    public Task<List<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        List<Product> products = InMemoryDB.Get_Products().ToList();
        
        return Task.FromResult(products);
    }
}
