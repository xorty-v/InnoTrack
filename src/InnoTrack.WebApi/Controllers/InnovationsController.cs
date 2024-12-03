using InnoTrack.WebApi.Contracts.Innovations;
using InnoTrack.WebApi.Services;
using Microsoft.AspNetCore.Mvc;
using Nest;

namespace InnoTrack.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class InnovationsController : ControllerBase
{
    private readonly IInnovationService _innovationService;

    public InnovationsController(IInnovationService innovationService)
    {
        _innovationService = innovationService;
    }

    [HttpGet]
    public async Task<ActionResult> GetAll([FromQuery] GetInnovationsRequest request,
        CancellationToken cancellationToken)
    {
        var innovations = await _innovationService.GetAllInnovationsAsync(request, cancellationToken);

        return Ok(innovations);
    }

    [HttpGet("search")]
    public async Task<IActionResult> Search([FromQuery] SearchInnovationsRequest request,
        CancellationToken cancellationToken)
    {
        var innovations = await _innovationService.SearchInnovationsAsync(request, cancellationToken);

        return Ok(innovations);
    }

    [HttpGet("generatePdf/{id}")]
    public async Task<IActionResult> GeneratePdf(int id, CancellationToken cancellationToken)
    {
        var pdfBytes = await _innovationService.GeneratePdf(id, cancellationToken);

        return File(pdfBytes, "application/pdf", $"innovation-{id}.pdf");
    }

    [HttpPost]
    public async Task<ActionResult> Add([FromBody] AddOrUpdateInnovationRequest request,
        CancellationToken cancellationToken)
    {
        await _innovationService.AddInnovationAsync(request, cancellationToken);

        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(int id, [FromBody] AddOrUpdateInnovationRequest request,
        CancellationToken cancellationToken)
    {
        await _innovationService.UpdateInnovationAsync(id, request, cancellationToken);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        await _innovationService.DeleteInnovationAsync(id, cancellationToken);

        return NoContent();
    }
}