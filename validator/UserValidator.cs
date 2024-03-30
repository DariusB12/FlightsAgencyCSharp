using System.Data.Entity.Core.Common;
using ProjectCS.exception;
using ProjectCS.model;

namespace ProjectCS.validator
{
    public class UserValidator
    {
        public void Validate(User entity)
        {
            string errors = "";
            if (string.IsNullOrEmpty(entity.Username)) {
                errors += "invalid username\n";
            }
            if (string.IsNullOrEmpty(entity.Password)) {
                errors += "invalid password\n";
            }
            if (errors != "") {
                throw new ValidationException(errors);
            }
        }
    }
}