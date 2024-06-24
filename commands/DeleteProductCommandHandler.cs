using MediatR;

namespace clean_architecture_using_mediatR;

public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
{
    public Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        InMemoryDB.RemoveProduct(request.Id);
        return  Task.CompletedTask;
    }
}
