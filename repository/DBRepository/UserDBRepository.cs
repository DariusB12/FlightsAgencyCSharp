using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq.Expressions;
using log4net;
using log4net.Repository.Hierarchy;
using ProjectCS.model;
using ProjectCS.repository.interfaces;
using ProjectCS.utils;
using ProjectCS.validator;

namespace ProjectCS.repository.DBRepository
{
    public class UserDBRepository :IUserDBRepository
    {
        private static readonly ILog log = LogManager.GetLogger("UserDBRepository");
        private IDictionary<String, String> prop;
        private readonly UserValidator userValidator = new UserValidator();

        public UserDBRepository(IDictionary<string, string> prop)
        {
            log.Info("Initializing the UserDBRepository with properties");
            this.prop = prop;
        }

        public User findByusernameAndPassword(string username, string password)
        {
            log.InfoFormat("Find user by username {0} and password {1}",username,password);
            IDbConnection con = DBUtils.getConnection(prop);
            
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "SELECT id,username,password from users" + 
                                   " WHERE username=@username AND password = @password";
                IDbDataParameter paramUsername = comm.CreateParameter();
                IDbDataParameter paramPassword = comm.CreateParameter();
                paramUsername.ParameterName = "@username";
                paramPassword.ParameterName = "@password";
                paramUsername.Value = username;
                paramPassword.Value = PasswordEncoder.encodePassword(password);
                comm.Parameters.Add(paramUsername);
                comm.Parameters.Add(paramPassword);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        //initializing the user with the null password,
                        //because we need it only to check the validity of the user
                        int id = dataR.GetInt32(0);
                        User user = new User(username, null);
                        user.Id = id;
                        log.InfoFormat("Exiting findByusernameAndPassword with value {0}", user);
                        return user;
                    }
                }
            }
            log.Info("Did not findByusernameAndPassword");
            return null;
        }

        public User findByUsername(string username)
        {
            log.InfoFormat("Find user by username {0}",username);
            IDbConnection con = DBUtils.getConnection(prop);
            
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "SELECT id,username from users" + 
                                   " WHERE username=@username";
                IDbDataParameter paramUsername = comm.CreateParameter();
                paramUsername.ParameterName = "@username";
                paramUsername.Value = username;
                comm.Parameters.Add(paramUsername);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        //initializing the user with the null password,
                        //because we need it only to check the validity of the user
                        int id = dataR.GetInt32(0);
                        User user = new User(username, null);
                        user.Id = id;
                        log.InfoFormat("Exiting findByusername with value {0}", user);
                        return user;
                    }
                }
            }
            log.Info("Did not findByUsername");
            return null;
        }

        public User findOne(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> findAll()
        {
            throw new System.NotImplementedException();
        }

        public User save(User entity)
        {
            log.InfoFormat("Save the user: {0} with id {1}",entity.Username,entity.Id);
            log.InfoFormat("Validate the user: {0} with id {1}",entity.Username,entity.Id);
            userValidator.Validate(entity);
            
            var con = DBUtils.getConnection(prop);
            User user = this.findByUsername(entity.Username);
            if (user != null)
            {
                log.ErrorFormat("Username already taken {0}",entity.Username);
                return null;
            }
            
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "INSERT INTO users(username,password)" +
                                   " VALUES (?,?)";
                var paramUsername = comm.CreateParameter();
                var paramPassword = comm.CreateParameter();

                paramUsername.ParameterName = "@username";
                paramPassword.ParameterName = "@password";
                paramUsername.Value = entity.Username;
                paramPassword.Value = PasswordEncoder.encodePassword(entity.Password);

                comm.Parameters.Add(paramUsername);
                comm.Parameters.Add(paramPassword);
                int generatedKey = Convert.ToInt32(comm.ExecuteScalar());
                entity.Id = generatedKey;
                log.InfoFormat("User saved with success: username:{0} id:{1}",entity.Username,entity.Id);
                return entity;
            }
        }

        public void delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void update(User entity)
        {
            throw new System.NotImplementedException();
        }

        
    }
}