namespace VegetableVideos.Model;
public class Video
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public int VideoLength { get; set; }
    public DateOnly UploadDate { get; set; }
}