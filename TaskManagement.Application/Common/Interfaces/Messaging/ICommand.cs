using MediatR;


namespace TaskManagement.Application.Common.Interfaces.Messaging
{
    public interface ICommand<TRequest> : IRequest<TRequest>;
}
