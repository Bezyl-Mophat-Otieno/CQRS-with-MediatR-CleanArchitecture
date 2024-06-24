using MediatR;

namespace clean_architecture_using_mediatR;

public class DeleteProductCommand:IRequest
{
    public int Id { get; set; }

}
