using MediatR;

namespace clean_architecture_using_mediatR;

public class GetProductQuery:IRequest<Product?>
{
    public int Id { get; set; }

}
