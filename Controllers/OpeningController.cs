using DayofWeekTest.Entities;
using DayofWeekTest.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DayofWeekTest.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OpeningController : ControllerBase
{
    private readonly IOpeningRepository _repository ;
   
    public OpeningController(IOpeningRepository repository)
    {
       
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }


    [HttpPost]
    [ProducesResponseType(typeof(List<string>), (int)HttpStatusCode.OK)]
    public IActionResult AddOpeningHour([FromBody]DaysOfTheWeek model)
    {
        var opening =  _repository.AddOpeningHour(model);
        
        return Ok(opening);
    }
}
