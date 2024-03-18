using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using log4net;
using ProjectCS.model;
using ProjectCS.repository.interfaces;

namespace ProjectCS.repository.DBRepository
{
    public class UserDBRepository :IUserDBRepository
    {
        private static readonly ILog log = LogManager.GetLogger("UserDBRepository");
        private IDictionary<String, String> prop;

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
                paramPassword.Value = password;
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
            log.Info("Did not findByusernameAndPassword with");
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

        public void save(User entity)
        {
            throw new System.NotImplementedException();
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