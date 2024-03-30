using System;
using ProjectCS.exception;
using ProjectCS.model;
using ProjectCS.repository.DBRepository;
using ProjectCS.repository.interfaces;

namespace ProjectCS.service
{
    public class UserService
    {
        private readonly IUserDBRepository userRepository;

        public UserService(IUserDBRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User signIn(string username, string password)
        {
            User user = userRepository.findByusernameAndPassword(username, password);
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new ServiceException("Invalid username or password\n");
            }
        }

        public void signUp(User user)
        {
            User userResult = userRepository.save(user);
            if (userResult != null)
            {
                throw new ServiceException("Username already taken\n");
            }
        }
    }
    
}