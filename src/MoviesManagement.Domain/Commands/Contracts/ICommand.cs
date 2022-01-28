using MediatR;

namespace MoviesManagement.Domain.Commands.Contracts;

public interface ICommand : IRequest<ICommandResult>
{
    
}