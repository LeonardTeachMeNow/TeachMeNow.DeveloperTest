using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TeachMeNow.DeveloperTest.BackEnd.Models;

namespace TeachMeNow.DeveloperTest.BackEnd.Controllers
{
    public class SessionController : ApiController
    {
        public SessionController()
        {
        }

        /// <summary>
        /// TODO - Get all the sessions from the database.
        /// </summary>
        /// <returns>A list of sessions</returns>
        public IEnumerable<Session> Get()
        {
            return null;
        }

        /// <summary>
        /// TODO get a single session from the database.
        /// </summary>
        /// <param name="id">The session ID</param>
        /// <returns>A session</returns>
        public Session Get(int id)
        {
            return null;
        }

        /// <summary>
        /// TODO - Adds a new session to the database.
        /// </summary>
        /// <param name="session">The session to add</param>
        /// <returns></returns>
        public IHttpActionResult Post([FromBody]Session session)
        {
            return Ok();
        }

        /// <summary>
        /// TODO - Updates a session in the database.
        /// </summary>
        /// <param name="id">The session ID to update</param>
        /// <param name="session">The new Session</param>
        /// <returns></returns>
        public IHttpActionResult Put(int id, [FromBody]Session session)
        {
            return Ok();
        }

        /// <summary>
        /// TODO - Deletes a session
        /// </summary>
        /// <param name="id">The session ID to delete</param>
        /// <returns></returns>
        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}