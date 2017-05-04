using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TeachMeNow.DeveloperTest.BackEnd.Models;

namespace TeachMeNow.DeveloperTest.BackEnd.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class UsersController : ApiController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        public UsersController()
        {
        }

        /// <summary>
        /// TODO - Get all the users from the database.
        /// </summary>
        /// <returns>A list of users.</returns>
        public IEnumerable<User> Get()
        {
            return null;
        }

        /// <summary>
        /// TODO - Get a single user from the database.
        /// </summary>
        /// <param name="id">The user ID</param>
        /// <returns>A user.</returns>
        public User Get(int id)
        {
            return null;
        }
    }
}