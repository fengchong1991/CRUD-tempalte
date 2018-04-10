using CRUD_Generic.Core.Data;
using CRUD_Generic.Service;
using CRUD_Generic.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Generic.Web.Controllers
{
    public class UserController : Controller
    {

        private IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<UserModel> users = userService.GetUsers().Select(u => new UserModel
            {
                FirstName = u.UserProfile.FirstName,
                LastName = u.UserProfile.LastName,
                Email = u.Email,
                Address = u.UserProfile.Address,
                ID = u.ID
            });
            return View(users);
        }

    }
}