using ProjectCS.model;

namespace ProjectCS.repository.interfaces
{
    public interface IUserDBRepository : ICrudRepository<int,User>
    {
        /// <summary>
        ///Get a user based on the given username and password
        /// </summary>
        /// <param name="username">The user username</param>
        /// <param name="password">The user password</param>
        /// <returns>
        ///     User if password and username match
        ///     null otherwise
        /// </returns>
        User findByusernameAndPassword(string username, string password);
    }
}