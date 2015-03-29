using ComidaService.DataAccess;
using ComidaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ComidaService.Controllers
{
    public class UserController : ApiController
    {
        UserAccessor userAccessor;

        public UserController()
        {
            userAccessor = new UserAccessor();
        }

        /*GET OPERATIONS */

        [HttpGet]
        public List<user> getAllUsers()
        {
            return null;
        }

        [HttpGet]
        public user getUserByID(int id)
        {
            return null;
        }

        [HttpGet]
        public user getUserByEmailAndPassword(string email, string password)
        {
            return null;
        }

        /*POST OPERATIONS (add) */

        [HttpPost]
        public void addUser(user u)
        {
            
        }

        /* PUT OPERATIONS (update) */

        [HttpPut]
        public void updateUser(user u)
        {

        }

        /* DELETE OPERATIONS */

        [HttpPut]
        public void deleteUser(user u)
        {

        }
    }
}
