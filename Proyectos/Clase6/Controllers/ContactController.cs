using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ApiSQLPlatzi.Models;
using System.Threading.Tasks;

namespace ApiSQLPlatzi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : Controller
    {
        private ContactsContext contactsContext;

        public ContactController(ContactsContext context)
        {
            contactsContext = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Contacts>> Get()
        {
            return contactsContext.ContactSet.ToList();
        }

        ~ContactController()
        {
            contactsContext.Dispose();
        }
    }
}