using MediatR;


namespace TaskManagement.Application.Common.Interfaces.Messaging
{
    public interface IQuery<TRequest> : IRequest<TRequest>;

}
