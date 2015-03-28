using ComidaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComidaService.DataAccess
{
    public class UserAccessor
    {
        public List<user> getAllUsers()
        {
            List<user> result = null;

            using (var context = new Entities())
            {
                result = context.user.ToList();
            }
            return result;
        }

        public List<user> validateUser(String email, String password)
        {
            List<user> result = null;

            using (var context = new Entities())
            {
                String quary = "SELECT * FROM `comida-db`.user where Email = @p0 and Password = @p1;";
                result = context.user.SqlQuery(quary,email,password).ToList(); 
            }
            return result;
        }

    }
}