using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // if you go to api/activities, you get the endpoint from ActivitiesController
    public class BaseApiController : ControllerBase
    {

    }
}