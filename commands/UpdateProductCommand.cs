using MediatR;

namespace clean_architecture_using_mediatR;

public class UpdateProductCommand:IRequest
{
    public required Product Product { get; set; }
    public required int Id { get; set; }

}
