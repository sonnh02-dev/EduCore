namespace EduCore.BackEnd.SharedKernel;

public sealed record Error
{
    public static readonly Error None = new(string.Empty, string.Empty, ErrorType.None);
    public static readonly Error NullValue = new("Error.NullValue", "Null value was provided", ErrorType.Failure);

    public string Code { get; init; }
    public string Description { get; init; }
    public ErrorType Type { get; init; }
    public string? Field { get; init; }

    private Error(string code, string description, ErrorType type, string? field = null)
    {
        Code = code;
        Description = description;
        Type = type;
        Field = field;
    }

    public static Error Validation(string code, string description, string? field = null) =>
        new(code, description, ErrorType.Validation, field);

    public static Error NotFound(string code, string description) =>
        new(code, description, ErrorType.NotFound);

    public static Error Conflict(string code, string description) =>
        new(code, description, ErrorType.Conflict);

    public static Error Failure(string code, string description) =>
        new(code, description, ErrorType.Failure);

    public static Error Unauthorized(string code, string description) =>
        new(code, description, ErrorType.Unauthorized);

    public static Error Forbidden(string code, string description) =>
        new(code, description, ErrorType.Forbidden);
}
