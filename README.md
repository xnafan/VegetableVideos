# Vegetable Videos
- a slightly silly ASP.NET Core Web API solution for testing search

![image](https://user-images.githubusercontent.com/3811290/210065726-3c301664-9b6b-44a9-871c-22f7359e87d6.png)

This Web API was created for people who want to learn how to use a REST API as a back-end for a UI project.  
The solution consists of two controllers with the following methods:

* VideosController
```C#
public IEnumerable<Video>? GetAll()
public ActionResult<Video> GetVideoById(int id)
public ActionResult<IEnumerable<Video>> SearchByPartOfName(string partOfName)
public ActionResult<IEnumerable<Video>> GetVideosNewerThanDate(string earliestDateString)
public ActionResult<IEnumerable<Video>> SearchByVideoLength(int minLengthInSeconds, int maxLengthInSeconds)
```
* ThumbnailsController
