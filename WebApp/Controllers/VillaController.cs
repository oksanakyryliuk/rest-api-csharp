using Microsoft.AspNetCore.Mvc;
using WebMagic.Models;

namespace WebMagic.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaController: ControllerBase
    {
        [HttpGet]
        public IEnumerable<Villa> GetVallas() 
        {
            return new List<Villa>
            {
                new Villa{Id=1, Name="Pool View"},
                new Villa {Id=2, Name="Beach View"},
            };
        }

    }
}
