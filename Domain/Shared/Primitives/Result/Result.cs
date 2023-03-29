namespace Domain.Shared.Primitives.Result;

public class Result
{
    public bool IsSuccess { get; init; }
    public bool IsFailure => !IsSuccess;
}
