namespace Domain.Shared.Primitives.Result;

public class Result<TValue> : Result
{
    public TValue? Data { get; set; }
}
