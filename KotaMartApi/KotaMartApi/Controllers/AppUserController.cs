using KotaMartApi.Data;
using KotaMartApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KotaMartApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly KmAppDbContext _context;

        public AppUserController(KmAppDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public ActionResult<KmAppUser> getUser(string userName, string password)
        //{
        //    var user = _context.AppUser.FirstOrDefault(x => x.AppUser == userName && x.Password == password);
        //    if (user != null)
        //    {
        //        return Ok(user);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}

        //[HttpGet("{id}")]
        //public ActionResult<KmAppUser> getUser(int id)
        //{
        //    var user = _context.AppUser.FirstOrDefault(x => x.Id == id);
        //    if (user != null)
        //    {
        //        return user;
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}


        [HttpGet]
        public ActionResult <IEnumerable<KmAppUser>> getUsers()
        {
            var users = _context.AppUser.ToList();
            if (users != null)
            {
                return users;
            }
            else
            {
                return NotFound();
            }
        }


    }
}
