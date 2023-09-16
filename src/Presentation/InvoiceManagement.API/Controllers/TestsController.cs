using InvoiceManagement.Persistence.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private InvoiceManagementDbContext _context;
        public async Task<IActionResult> Get()
        {

            return Ok();
        }
    }
}
