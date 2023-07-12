using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WorkFlowX.Server.Application.Interfaces;
using WorkFlowX.Server.Domain;

namespace WorkFlowX.Server.API.Controllers;

[ApiController]
[Route("[controller]")]
[EnableCors("WorkFlowXPolicy")]
public class JobController : ControllerBase
{
    private readonly ILogger<JobController> _logger;
    private readonly IWorkOrderService _dataBridgeService;

    public JobController(ILogger<JobController> logger, 
        IWorkOrderService dataBridgeService)
    {
        _logger = logger;
        _dataBridgeService = dataBridgeService;
    }

    public async Task<List<Job>> Get() => 
    await _dataBridgeService.GetJobsAsync();

    //[HttpPost(Name = "operation")]
    //public async Task<JsonResult> Post([FromQuery] string application, [FromQuery] string operation, [FromBody] string content)
    //{
    //    return new JsonResult(await _dataBridgeService.PostData(application, operation, content));
    //}
}