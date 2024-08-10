using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RunningTrackerApi.Models;
using RunningTrackerApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunningTrackerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunningActivitiesController : ControllerBase
    {
        private readonly IRunningActivityService _service;
        private readonly ILogger<RunningActivitiesController> _logger;

        public RunningActivitiesController(IRunningActivityService service, ILogger<RunningActivitiesController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<RunningActivity>> GetRunningActivity(int id)
        {
            var runningActivity = await _service.GetRunningActivityAsync(id);
            if (runningActivity == null)
            {
                return NotFound();
            }
            return Ok(runningActivity);
        }

        [HttpPost]
        public async Task<ActionResult<RunningActivity>> PostRunningActivity(RunningActivity runningActivity)
        {
            await _service.AddRunningActivityAsync(runningActivity);
            return CreatedAtAction(nameof(GetRunningActivity), new { id = runningActivity.Id }, runningActivity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRunningActivity(int id, RunningActivity runningActivity)
        {
            if (id != runningActivity.Id)
            {
                return BadRequest();
            }

            try
            {
                await _service.UpdateRunningActivityAsync(runningActivity);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await _service.GetRunningActivityAsync(id) == null)
                {
                    return NotFound();
                }
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRunningActivity(int id)
        {
            await _service.DeleteRunningActivityAsync(id);
            return NoContent();
        }
    }
}
