namespace BlazorBlog.Models;

public class BlogPost
{
    public string Title { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; }
    public string Tags { get; set; } = string.Empty;
}
