using MediatR;
using MoviesManagement.Domain.Commands;
using MoviesManagement.Domain.Commands.Contracts;
using MoviesManagement.Domain.Handlers;

namespace MoviesManagement.Core.Handlers;

public class HandlerMovies : IHandler<MoviesCreateCommand>
{
    public Task<ICommandResult> Handle(MoviesCreateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}