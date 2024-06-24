using MediatR;

namespace clean_architecture_using_mediatR;

public class AddProductCommand:IRequest
{
    public required Product Product { get; set; }

}
