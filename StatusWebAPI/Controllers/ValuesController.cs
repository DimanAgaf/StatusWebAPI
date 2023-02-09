using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StatusWebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		// GET: api/<ValuesController>
		[HttpGet]
		public List<APIResponse> Get()
		{
			return new List<APIResponse> { new APIResponse() { Id = -1, Status = "Error", Message = "Not found" } };
		}

		// POST api/<ValuesController>
		[HttpPost]
		public ObjectResult Post([FromBody] List<APIRequest> value)
		{
			try
			{
				List<APIResponse> aPIResponse = new List<APIResponse>();
				foreach (var item in value)
				{
					aPIResponse.Add(new APIResponse() { Id = item.Id, Status = "Готов", Message = "урааа" });
				}

				return Ok(aPIResponse);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
