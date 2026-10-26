using MediatR;


namespace TaskManagement.Application.Common.Interfaces.Messaging
{
    public interface IQueryHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IQuery<TResponse>;

}
