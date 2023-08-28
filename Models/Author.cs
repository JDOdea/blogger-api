namespace Blogger.Models;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Blog> Blogs { get; set; }
    public List<Comment> Comments { get; set; }
}