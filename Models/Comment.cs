namespace Blogger.Models;

public class Comment
{
    public int Id { get; set; }
    public int ArticleId { get; set; }
    public int  AuthorId { get; set; }
    public string Message { get; set; }
}