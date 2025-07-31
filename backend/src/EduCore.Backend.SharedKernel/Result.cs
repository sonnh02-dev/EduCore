namespace EduCore.BackEnd.SharedKernel;

public class Result
{
    public bool IsSuccess { get; init; }
    public string? Message { get; init; } = string.Empty;

    public List<Error> Errors { get; init; } = new();

    public bool IsFailure => !IsSuccess;

    public static Result Success(string message = "Success") => new()
    {
        IsSuccess = true,
        Message = message,
        Errors = new()
    };

    public static Result Failure(Error error, string message = "Failure")
        => Failure(new List<Error> { error }, message);

    public static Result Failure(List<Error> errors, string message = "Failure")
    {
        return new Result
        {
            IsSuccess = false,
            Message = message,
            Errors = errors
        };
    }
}

public class Result<T> : Result
{
    public T? Data { get; init; }

    public static Result<T> Success(T data, string message = "Success") => new()
    {
        IsSuccess = true,
        Data = data,
        Message = message
    };

    public static Result<T> Failure(Error error, string message = "Failure")
        => Failure(new List<Error> { error }, message);

    public static Result<T> Failure(List<Error> errors, string message = "Failure") => new()
    {
        IsSuccess = false,
        Data = default,
        Message = message,
        Errors = errors
    };
}
