using ChatingApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace ChatingApp.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class UserController : ControllerBase
	{
		private readonly DataContext _context;
		public UserController(DataContext context)
		{
			_context = context;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllUsers()
		{
			return Ok();
		}
	}
}
