using Microsoft.AspNetCore.Mvc;
namespace VegetableVideos.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ThumbnailsController : ControllerBase
{

    // GET: api/thumbnails/5
    [HttpGet("{id}")]
    public ActionResult GetThumbnail(int id)
    {
        var imageFolderPath = $"Images/";
        var numberOfImages = Directory.GetFiles(imageFolderPath).Count();

        var idToUse = id % numberOfImages;

        // Build the file path for the thumbnail image
        // using prefixed zeros for single digit number
        var filePath = $"Images/vegetable_video_{idToUse:00}.png";

        // Read the thumbnail image into a byte array
        var imageData = System.IO.File.ReadAllBytes(filePath);
        var fileName = Path.GetFileName(filePath);
        // Return the image data in the response
        return File(imageData, "image/png", fileName);
    }
}