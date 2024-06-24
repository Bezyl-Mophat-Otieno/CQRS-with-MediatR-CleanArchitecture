using MediatR;

namespace clean_architecture_using_mediatR;

public class AddProductRequestHandler : IRequestHandler<AddProductCommand>
{
    public Task Handle(AddProductCommand request, CancellationToken cancellationToken)
    {
        InMemoryDB.AddProduct(request.Product);
        return Task.CompletedTask;
    }
}
