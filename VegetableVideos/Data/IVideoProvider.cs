using VegetableVideos.Model;

namespace VegetableVideos.Data
{
    public interface IVideoProvider
    {
        IEnumerable<Video>? GetAll();
        Video? GetVideoById(int id);
        IEnumerable<Video>? GetVideosByPartOfName(string partOfName);
        IEnumerable<Video>? GetVideosNewerThanDate(DateOnly earliestDate);
        IEnumerable<Video>? SearchByVideoLength(int minLengthInSeconds, int maxLengthInSeconds);
    }
}