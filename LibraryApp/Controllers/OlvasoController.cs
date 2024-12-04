using LibraryApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApp.Controllers;

[ApiController]
[Route("olvaso")]
public class OlvasoController : ControllerBase
{
    private IOlvasoService _olvasoService;

    public OlvasoController(IOlvasoService olvasoService)
    {
        _olvasoService = olvasoService;
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Olvaso olvaso)
    {
        var existingOlvaso = await _olvasoService.GetAsync(olvaso.OSz);

        if (existingOlvaso is not null)
        {
            return Conflict();
        }

        await _olvasoService.AddAsync(olvaso);

        return Ok();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var olvaso = await _olvasoService.GetAsync(id);

        if (olvaso is null)
        {
            return NotFound();
        }

        await _olvasoService.DeleteAsync(id);

        return Ok();
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Olvaso>> Get(Guid id)
    {
        var olvaso = await _olvasoService.GetAsync(id);

        if (olvaso is null)
        {
            return NotFound();
        }

        return Ok(olvaso);
    }

    [HttpGet]
    public async Task<ActionResult<List<Olvaso>>> Get()
    {
        return Ok(await _olvasoService.GetAllAsync());
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] Olvaso newOlvaso)
    {
        if (id != newOlvaso.OSz)
        {
            return BadRequest();
        }

        var existingOlvaso = await _olvasoService.GetAsync(id);

        if (existingOlvaso is null)
        {
            return NotFound();
        }

        await _olvasoService.UpdateAsync(newOlvaso);

        return Ok();
    }
}