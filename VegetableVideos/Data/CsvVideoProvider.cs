using VegetableVideos.Model;

namespace VegetableVideos.Data;
public class CsvVideoProvider : IVideoProvider
{

    private static List<Video> _videos = GetVideosFromCsvFile("Data/vegetable_videos.csv").ToList();

    private static IEnumerable<Video> GetVideosFromCsvFile(string filePath)
    {
        // Read the file and parse the rows
        var rows = File.ReadAllLines(filePath)
            .Skip(1) // Skip the first row (header row)
            .Select(row => row.Split(';'));

        // Convert the rows to Video objects
        return rows.Select(row => new Video
        {
            Id = int.Parse(row[0]),
            Title = row[1],
            VideoLength = int.Parse(row[2]),
            UploadDate = DateOnly.Parse(row[3])
        });
    }

    public IEnumerable<Video>? GetAll() => _videos;
    public Video? GetVideoById(int id)
    {
        return _videos.FirstOrDefault(video => video.Id == id);
    }

    public IEnumerable<Video>? GetVideosByPartOfName(string partOfName)
    {
        return _videos.Where(video => video.Title.Contains(partOfName, StringComparison.OrdinalIgnoreCase));
    }

    public IEnumerable<Video>? GetVideosNewerThanDate(DateOnly earliestDate)
    {
        return _videos.Where(video => video.UploadDate.CompareTo(earliestDate) > 0);
    }

    public IEnumerable<Video>? SearchByVideoLength(int minLengthInSeconds, int maxLengthInSeconds)
    {
        return _videos.Where(video => video.VideoLength >= minLengthInSeconds && video.VideoLength <= maxLengthInSeconds);
    }

}
