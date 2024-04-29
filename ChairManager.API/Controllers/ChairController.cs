using ChairManager.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChairManager.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChairController : ControllerBase
{
    private readonly AppDbContext _context;
    
    public ChairController(AppDbContext appContext)
    {
        _context = appContext;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var chairs = await _context.Chairs.ToListAsync();
        return Ok(chairs);
    }


}