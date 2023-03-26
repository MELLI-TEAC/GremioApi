using Domain.Shared.Primitives.Result;

namespace Application.Share.Abstraction.Messaging;

internal interface ICommand : IRequest<Result>
{
}

internal interface ICommand<TResponse> : IRequest<Result<TResponse>>
{
}
