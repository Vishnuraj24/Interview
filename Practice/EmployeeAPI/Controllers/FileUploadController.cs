using EmployeeAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        [HttpPost]
        [Route("upload")]
        [Consumes("multipart/form-data")] // Tell Swagger the content type

        public async Task<IActionResult> UploadFile([FromForm] FileUploadModel model)
        {
            var file = model.File;
            //check the file is uploaded or not
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file Uploaded");
            }

            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles");

            if (!Directory.Exists(folderPath)) { 
            
                Directory.CreateDirectory(folderPath);    
            }

            var filePath = Path.Combine(folderPath, file.FileName);

            using(var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Ok(new {message = "File Uploaded Successfully",fileName = file.FileName});
        }

    }
}
