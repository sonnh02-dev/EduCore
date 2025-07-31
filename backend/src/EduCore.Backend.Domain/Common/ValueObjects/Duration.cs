using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Common.ValueObjects
{
    public sealed class Duration : ValueObject
    {
        public TimeSpan Value { get; }

        private Duration(TimeSpan value)
        {
            Value = value;
        }

        public static Result<Duration> Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return Result<Duration>.Failure(Error.Validation("Duration.Invalid", "Duration cannot be empty."));

            value = value.Trim();

            // Format hh:mm:ss or hh:mm
            if (TimeSpan.TryParse(value, out var parsed))
            {
                if (parsed.TotalMinutes <= 0)
                    return Result<Duration>.Failure(Error.Validation("Duration.Invalid", "Duration must be greater than 0."));
                return Result<Duration>.Success(new Duration(parsed));
            }

            // Match formats like "3h 20m", "2h", "45m"
            var regex = new Regex(@"^(?:(\d+)\s*h)?\s*(?:(\d+)\s*m)?$", RegexOptions.IgnoreCase);
            var match = regex.Match(value);

            if (!match.Success)
            {
                return Result<Duration>.Failure(Error.Validation("Duration.Invalid", "Invalid duration format. Use formats like '3h 20m', '90m' or '01:30:00'."));
            }

            int hours = match.Groups[1].Success ? int.Parse(match.Groups[1].Value) : 0;
            int minutes = match.Groups[2].Success ? int.Parse(match.Groups[2].Value) : 0;

            var timeSpan = new TimeSpan(hours, minutes, 0);
            if (timeSpan.TotalMinutes <= 0)
            {
                return Result<Duration>.Failure(Error.Validation("Duration.Invalid", "Duration must be greater than 0."));
            }

            return Result<Duration>.Success(new Duration(timeSpan));
        }

        public string ToReadableString()
        {
            if (Value.TotalHours < 1)
                return $"{Value.Minutes}m";
            if (Value.Minutes == 0)
                return $"{(int)Value.TotalHours}h";
            return $"{(int)Value.TotalHours}h {Value.Minutes}m";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => ToReadableString();
    }
}
