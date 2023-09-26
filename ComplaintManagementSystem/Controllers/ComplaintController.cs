using Microsoft.AspNetCore.Mvc;
namespace dotnetapp.Controllers
{
    public class ComplaintController : Controller
    {
        private readonly ApplicationDbContext _context;
          public BatchController(ApplicationDbContext context)
        {
            _context = context;
        }
    public IActionResult AvailableBatches()
    {
        var data=_context.Batches.ToList();
        return View(data);
    }
       public IActionResult BookedBatches()
        {
            return View();
        }
    }
}