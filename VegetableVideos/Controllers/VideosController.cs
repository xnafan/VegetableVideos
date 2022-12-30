using Microsoft.AspNetCore.Mvc;
using VegetableVideos.Data;
using VegetableVideos.Model;

namespace VegetableVideos.Controllers;

[Route("api/videos")]
[ApiController]
public class VideosController : ControllerBase
{

    private IVideoProvider _videoProvider;

    public VideosController(IVideoProvider videoProvider) => _videoProvider = videoProvider;

    [HttpGet]
    public IEnumerable<Video>? GetAll() => _videoProvider.GetAll();

    // GET: api/videos/5
    [HttpGet("{id}")]
    public ActionResult<Video> GetVideoById(int id)
    {
        var video = _videoProvider.GetVideoById(id);
        if (video == null)
        {
            return NotFound();
        }
        return Ok(video);
    }

    // GET: api/videos/search?partOfName=veggie
    [HttpGet("search")]
    public ActionResult<IEnumerable<Video>> SearchByPartOfName(string partOfName)
    {
        var videos = _videoProvider.GetVideosByPartOfName(partOfName);
        if (videos == null || !videos.Any())
        {
            return NotFound();
        }
        return Ok(videos);
    }

    // GET: api/videos/newerthandate?earliestDate=2022-01-01
    [HttpGet("newerthandate")]
    public ActionResult<IEnumerable<Video>> GetVideosNewerThanDate(string earliestDateString)
    {
        if (!DateOnly.TryParse(earliestDateString, out DateOnly earliestDate))
        {
            return BadRequest($"Unable to parse {earliestDateString} as a DateOnly. Please use the format 'yyyy-MM-dd'.");
        }
        var videos = _videoProvider.GetVideosNewerThanDate(earliestDate);
        if (videos == null || !videos.Any())
        {
            return NotFound();
        }
        return Ok(videos);
    }

    // GET: api/videos/searchbylength?minLengthInSeconds=600&maxLengthInSeconds=1800
    [HttpGet("searchbylength")]
    public ActionResult<IEnumerable<Video>> SearchByVideoLength(int minLengthInSeconds, int maxLengthInSeconds)
    {
        var videos = _videoProvider.SearchByVideoLength(minLengthInSeconds, maxLengthInSeconds);
        if (videos == null || !videos.Any())
        {
            return NotFound();
        }
        return Ok(videos);
    }
}