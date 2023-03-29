namespace Domain.Shared.Primitives.ValueObject;

public sealed class Error : ValueObject.Base.ValueObject
{
    public string Code { get; init; }
    public string Message { get; init; }

    public Error(string code, string message)
    {
        Code = code;
        Message = message;
    }

    public static implicit operator string(Error? error) => error?.Code ?? string.Empty;

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Code;
        yield return Message;
    }

    internal static Error None => new Error(string.Empty, string.Empty);
}
