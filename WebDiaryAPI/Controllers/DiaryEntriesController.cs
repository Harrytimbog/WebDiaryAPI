using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebDiaryAPI.Data;
using WebDiaryAPI.Models;

namespace WebDiaryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiaryEntriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DiaryEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IEnumerable<DiaryEntry> GetDiaryEntries()
        {
            return _context.DiaryEntries;
        }
    }
}
