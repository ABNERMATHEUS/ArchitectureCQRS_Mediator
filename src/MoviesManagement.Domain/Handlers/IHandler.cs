using MediatR;
using MoviesManagement.Domain.Commands.Contracts;

namespace MoviesManagement.Domain.Handlers;

public interface IHandler<in TCommand> :
    IRequestHandler<TCommand, ICommandResult> where TCommand : ICommand
{
    
}