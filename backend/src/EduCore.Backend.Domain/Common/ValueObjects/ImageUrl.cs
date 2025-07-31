using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.BackEnd.Domain.Common.Entities;
using EduCore.BackEnd.SharedKernel;

namespace EduCore.BackEnd.Domain.Common.ValueObjects
{
    public sealed class ImageUrl : ValueObject
    {
        public string Value { get; }

        private ImageUrl(string value)
        {
            Value = value;
        }

        public static Result<ImageUrl> Create(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))

                return Result<ImageUrl>.Success(null!); 

            if (value.StartsWith("http://") || value.StartsWith("https://"))
            {
                return Result<ImageUrl>.Failure(Error.Validation("ImageUrl.AbsoluteNotAllowed", "Only relative paths are allowed for image URLs."));
            }

            if (value.Contains("..") || value.StartsWith("/"))
            {
                return Result<ImageUrl>.Failure(Error.Validation("ImageUrl.InvalidPath", "Path cannot navigate up directories or start with a root slash."));
            }

            if (value.Length > 255)
            {
                return Result<ImageUrl>.Failure(Error.Validation("ImageUrl.TooLong", "Image path must be 255 characters or fewer."));
            }

            return Result<ImageUrl>.Success(new ImageUrl(value));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString() => Value;
    }
}
