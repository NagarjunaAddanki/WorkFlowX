using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WorkFlowX.Server.Application.Interfaces;

namespace WorkFlowX.Server.API.Controllers;

[ApiController]
[Route("[controller]")]
[EnableCors("WorkFlowXPolicy")]
public class DataController : ControllerBase
{
    private readonly ILogger<DataController> _logger;
    private readonly IWorkOrderService _dataBridgeService;

    public DataController(ILogger<DataController> logger, 
        IWorkOrderService dataBridgeService)
    {
        _logger = logger;
        _dataBridgeService = dataBridgeService;
    }

    //[HttpGet(Name = "operation")]
    //public async Task<JsonResult> Get(string application, string operation)
    //{
    //    Request.Headers.TryGetValue("x-operation-filter", out var filterJson);
    //    return new JsonResult(await _dataBridgeService.GetData(application, operation, filterJson));
    //}

    //[HttpPost(Name = "operation")]
    //public async Task<JsonResult> Post([FromQuery] string application, [FromQuery] string operation, [FromBody] string content)
    //{
    //    return new JsonResult(await _dataBridgeService.PostData(application, operation, content));
    //}
}