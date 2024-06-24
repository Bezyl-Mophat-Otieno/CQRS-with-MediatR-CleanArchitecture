using MediatR;

namespace clean_architecture_using_mediatR;

public class GetProductsQuery : IRequest<List<Product>>
{

}
