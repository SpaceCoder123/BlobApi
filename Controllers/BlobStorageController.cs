using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace BlobStorage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlobStorageController : ControllerBase
    {
        //private readonly IBlobService _blobService;
        [HttpPost]
        public async Task<IActionResult> SendImageToBlob(IFormFile imageFormat)
        {
            return Ok(imageFormat);
        }

        
    }
}
