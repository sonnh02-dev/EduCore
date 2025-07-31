using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Common.Enumerations
{
    public sealed class Level : Enumeration<Level>
    {
        public static readonly Level Beginner = new(1, "Beginner", "Dành cho người mới bắt đầu");
        public static readonly Level Intermediate = new(2, "Intermediate", "Trình độ trung cấp");
        public static readonly Level Advanced = new(3, "Advanced", "Trình độ nâng cao");

        private Level(int value, string name, string? description = null)
            : base(value, name, description)
        {
        }

        public bool IsBeginner => this == Beginner;
        public bool IsIntermediate => this == Intermediate;
        public bool IsAdvanced => this == Advanced;

        public static Result<Level> Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return Result<Level>.Failure(
                    Error.Validation("Level.Invalid", "Level name cannot be empty!")
                );
            }

            var match = FromName(name);
            if (match is null)
            {
                return Result<Level>.Failure(
                    Error.Validation("Level.Invalid", $"Invalid level name '{name}'")
                );
            }

            return Result<Level>.Success(match);
        }

        public static Result<Level> Create(int value)
        {
            var match = FromValue(value);
            if (match is null)
            {
                return Result<Level>.Failure(
                    Error.Validation("Level.Invalid", $"Invalid level value '{value}'")
                );
            }

            return Result<Level>.Success(match);
        }

    }
}
