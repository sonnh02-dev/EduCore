using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduCore.BackEnd.Domain.Common.ValueObjects
{
    public sealed class Title : ValueObject
    {
        public string Value { get; }

        private Title(string value)
        {


            Value = value;
        }

        public static Result<Title> Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return Result<Title>.Failure(Error.Validation("Rating.Invalid", "Title cannot be empty!"));


            if (value.Length > 100)
                return Result<Title>.Failure(Error.Failure("Rating.Failure", "Title is too long!"));

            return Result<Title>.Success(new Title(value));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value;
    }

}
