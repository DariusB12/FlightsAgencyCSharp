using System;
using ProjectCS.model;

namespace ProjectCS.validator
{
    public interface IValidator<T>
    { 
        void Validate(T entity);
    }
}