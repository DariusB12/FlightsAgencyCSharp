using System;
using ProjectCS.model;

namespace ProjectCS.validator
{
    public class ValidationException : ApplicationException
    {
        public ValidationException()
        {
        }

        public ValidationException(string message) : base(message)
        {
        }

        public ValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
    public interface IValidator<T>
    { 
        void validate(T entity);
    }
}