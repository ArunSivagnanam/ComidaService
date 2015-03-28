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

        // GET api/user
        public List<user> Get()
        {
            String email = "Arun.s@live.dk";
            String password = "1234";

            return userAccessor.validateUser(email, password);
        }

    }
}
