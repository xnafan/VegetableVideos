# Vegetable Videos
- a slightly silly ASP.NET Core Web API solution for testing search, containing "Get Rich Quick By Selling Vegetables" videos with AI generated titles and thumbnails.

![image](https://user-images.githubusercontent.com/3811290/210065726-3c301664-9b6b-44a9-871c-22f7359e87d6.png)

This Web API was created for people who want to learn how to use a REST API as a back-end for a UI project.  
The solution consists of two controllers with the following methods:

* VideosController
```C#
public IEnumerable<Video>? GetAll();
public ActionResult<Video> GetVideoById(int id);
public ActionResult<IEnumerable<Video>> SearchByPartOfName(string partOfName);
public ActionResult<IEnumerable<Video>> GetVideosNewerThanDate(string earliestDateString);
public ActionResult<IEnumerable<Video>> SearchByVideoLength(int minLengthInSeconds, int maxLengthInSeconds);
```
* ThumbnailsController
```C#
public ActionResult GetThumbnail(int id)
```
Using these controllers it is possible to write a UI (e.g. ASP.NET Core MVC) to present videos.

## Data
The titles for the videos about getting rich by selling vegetables were generated as a CSV file using ChatGPT, with the prompt: 'Please generate a csv file of funny titles for videos with tips on selling vegetables online. One column with the title, one column with a random video length in minutes and seconds and one column with a random date for upload (0-5 years in the past).'.

The titles are amazing: 

The Insider's Guide to Selling Vegetables Like a Pro
Vegetable-Selling Success: Achieving Your Goals with These Simple Tips
The Vegetable Seller's Handbook: Expert Tips and Tricks
How to Sell Veggies Like a Pro: A Comprehensive Guide
The Insider's Guide to Successfully Selling Vegetables Online
Veggie-Selling Tips from the Experts: What You Need to Know
Reaching the Pinnacle of Veggie-Selling Success: Advanced Strategies
The Vegetable Seller's Path to Nirvana: Expert Tips and Tricks
Maximizing Your Vegetable Sales: Achieving Ultimate Success
The Vegetable Seller's Journey to the Mountaintop: Advanced Techniques
Vegetable-Selling Mastery: The Ultimate Guide
The Ultimate Vegetable-Selling Enlightenment: Advanced Tips and Strategies

The images were generated mostly using MidJourney and a few using Open AI's Dall-E 2:
![image](https://user-images.githubusercontent.com/3811290/210066682-149c16aa-7552-438d-bb8c-39ccf504bff8.png)
