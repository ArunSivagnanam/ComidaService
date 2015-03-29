using ComidaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ComidaService.Controllers
{
    public class RecepeController : ApiController
    {

        /*GET OPERATIONS */

        [HttpGet]
        public recepe getAllPublishedRecepes()
        {
            return null;
        }

        [HttpGet]
        public recepe getAllUserRecepe(int id)
        {
            return null;
        }

        [HttpGet]
        public recepe getAllFavoriteRecepe(int id)
        {
            return null;
        }

        /* POST OPERATIONS (add) */

        [HttpPost]
        public void addRecepe(recepe recepe)
        {

        }
        
        [HttpPost]
        public void addRecepeStep(recepestep recepe)
        {

        }

        [HttpPost]
        public void addRecepeItem(recepeitem i)
        {

        }

        [HttpPost]
        public void addRecepeFavorite(int userId, int recepeId, int rating)
        {

        }

        [HttpPost]
        public void addRecepeMember(int userId, int recepeId)
        {

        }


        /* PUT OPERATIONS (Update) */

        [HttpPut]
        public void updateRecepe(recepe r)
        {

        }

        [HttpPut]
        public void updateRecepeStep(recepestep s)
        {

        }

        [HttpPut]
        public void updateRecepeItem(recepeitem i)
        {

        }

        /* DELETE OPERATIONS */

        [HttpDelete]
        public void deleteRecepe(recepe i)
        {

        }
        
    }
}
