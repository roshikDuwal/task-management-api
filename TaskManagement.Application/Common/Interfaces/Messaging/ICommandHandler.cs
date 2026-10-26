using MediatR;


namespace TaskManagement.Application.Common.Interfaces.Messaging
{
    public interface ICommandHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : ICommand<TResponse>;
  
}
