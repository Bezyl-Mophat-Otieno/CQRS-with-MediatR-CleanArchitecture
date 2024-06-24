using MediatR;

namespace clean_architecture_using_mediatR;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
{
    public Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        InMemoryDB.UpdateProduct(request.Product, request.Id);
        return Task.CompletedTask;
    }
}
