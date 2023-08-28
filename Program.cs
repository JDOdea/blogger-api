using Blogger.Models;

#region Lists
//  Blogs
List<Blog> blogs = new List<Blog>()
{
    new Blog()
    {
        Id = 1,
        Title = "Cool Stuff"
    },
    new Blog()
    {
        Id = 2,
        Title = "Dumb Stuff"
    },
    new Blog()
    {
        Id = 3,
        Title = "Silly Stuff"
    },
    new Blog()
    {
        Id = 4,
        Title = "Secret Stuff"
    },
};

//  BlogAuthors
List<BlogAuthor> blogAuthors = new List<BlogAuthor>()
{
    new BlogAuthor()
    {
        Id = 1,
        BlogId = 1,
        AuthorId = 5
    },
    new BlogAuthor()
    {
        Id = 2,
        BlogId = 1,
        AuthorId = 3
    },
    new BlogAuthor()
    {
        Id = 3,
        BlogId = 1,
        AuthorId = 6
    },
    new BlogAuthor()
    {
        Id = 4,
        BlogId = 2,
        AuthorId = 1
    },
    new BlogAuthor()
    {
        Id = 5,
        BlogId = 2,
        AuthorId = 2
    },
    new BlogAuthor()
    {
        Id = 6,
        BlogId = 3,
        AuthorId = 1
    },
    new BlogAuthor()
    {
        Id = 7,
        BlogId = 3,
        AuthorId = 4
    },
    new BlogAuthor()
    {
        Id = 8,
        BlogId = 3,
        AuthorId = 5
    },
    new BlogAuthor()
    {
        Id = 9,
        BlogId = 4,
        AuthorId = 4
    },
    new BlogAuthor()
    {
        Id = 10,
        BlogId = 4,
        AuthorId = 1
    },
};

//  Articles
List<Article> articles = new List<Article>()
{
    new Article()
    {
        Id = 1,
        BlogId = 2,
        Title = "Unlocking the Secrets: The Science Behind Productivity",
        DatePosted = new DateTime(2023, 08, 01)
    },
    new Article()
    {
        Id = 2,
        BlogId = 4,
        Title = "Mastering Your Mornings: How to Create a Successful Routine",
        DatePosted = new DateTime(2023, 08, 03)
    },
    new Article()
    {
        Id = 3,
        BlogId = 3,
        Title = "The Art of Effective Communication: Boost Your Relationships",
        DatePosted = new DateTime(2023, 08, 03)
    },
    new Article()
    {
        Id = 4,
        BlogId = 4,
        Title = "Mindful Living: Discover the Power of Being Present",
        DatePosted = new DateTime(2023, 08, 06)
    },
    new Article()
    {
        Id = 5,
        BlogId = 1,
        Title = "Financial Freedom Demystified: Steps to Secure Your Future",
        DatePosted = new DateTime(2023, 08, 10)
    },
    new Article()
    {
        Id = 6,
        BlogId = 2,
        Title = "From Dreams to Reality: A Practical Guide to Setting Goals",
        DatePosted = new DateTime(2023, 08, 14)
    },
    new Article()
    {
        Id = 7,
        BlogId = 1,
        Title = "The Healthy Plate: Exploring Nutrient-Rich Superfoods",
        DatePosted = new DateTime(2023, 08, 19)
    },
    new Article()
    {
        Id = 8,
        BlogId = 4,
        Title = "Exploring the Wonders of Nature: Outdoor Adventures Await",
        DatePosted = new DateTime(2023, 08, 24)
    },
    new Article()
    {
        Id = 9,
        BlogId = 3,
        Title = "Unleash Your Creativity: Strategies for a More Inspired Life",
        DatePosted = new DateTime(2023, 08, 25)
    },
    new Article()
    {
        Id = 10,
        BlogId = 2,
        Title = "The Power of Positivity: Transforming Challenges into Triumphs",
        DatePosted = new DateTime(2023, 08, 28)
    }
};

//  Comments
List<Comment> comments = new List<Comment>()
{
    new Comment()
    {
        Id = 1,
        ArticleId = 1,
        AuthorId = 1,
        Message = "First"
    },
    new Comment()
    {
        Id = 2,
        ArticleId = 1,
        AuthorId = 3,
        Message = "Fake news"
    },
    new Comment()
    {
        Id = 3,
        ArticleId = 1,
        AuthorId = 2,
        Message = "Stop lying and show us the truth"
    },
    new Comment()
    {
        Id = 4,
        ArticleId = 2,
        AuthorId = 6,
        Message = "Get wrekd"
    },
    new Comment()
    {
        Id = 5,
        ArticleId = 3,
        AuthorId = 5,
        Message = "Well put. Thank you for sharing!"
    },
    new Comment()
    {
        Id = 6,
        ArticleId = 4,
        AuthorId = 4,
        Message = "Meh, I've seen better"
    },
    new Comment()
    {
        Id = 7,
        ArticleId = 5,
        AuthorId = 3,
        Message = "Has anyone tried this before?"
    },
    new Comment()
    {
        Id = 8,
        ArticleId = 6,
        AuthorId = 1,
        Message = "Someone is in my house..."
    },
    new Comment()
    {
        Id = 9,
        ArticleId = 7,
        AuthorId = 1,
        Message = "Please help me, I'm so cold..."
    },
    new Comment()
    {
        Id = 10,
        ArticleId = 8,
        AuthorId = 1,
        Message = "When did MJ die again?"
    },
    new Comment()
    {
        Id = 11,
        ArticleId = 9,
        AuthorId = 1,
        Message = "R.I.P."
    },
    new Comment()
    {
        Id = 12,
        ArticleId = 10,
        AuthorId = 1,
        Message = "The first Thor movie taught me a lot about toxic masculinity"
    },
};

//  Authors
List<Author> authors = new List<Author>()
{
    new Author()
    {
        Id = 1,
        Name = "JD Fitzmartin"
    },
    new Author()
    {
        Id = 2,
        Name = "Josh Baugh"
    },
    new Author()
    {
        Id = 3,
        Name = "Jackson Henderson"
    },
    new Author()
    {
        Id = 4,
        Name = "Liza Vavrichyna"
    },
    new Author()
    {
        Id = 5,
        Name = "Alex Hare"
    },
    new Author()
    {
        Id = 6,
        Name = "Rhett Muse"
    }
};
#endregion

#region Default Needs
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
#endregion

#region Endpoints

#region Endpoint--Blogs
//  Get all Blogs
app.MapGet("/blogs", () =>
{
    return blogs;
});

//  Get specific Blog
app.MapGet("/blogs/{id}", (int id) =>
{
    Blog blog = blogs.FirstOrDefault(b => b.Id == id);
    if (blog == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(blog);
});

//  Get Blogs by a particular Author
app.MapGet("/authors/{authorId}/blogs", (int authorId) =>
{
    Author author = authors.FirstOrDefault(a => a.Id == authorId);
    if (author == null)
    {
        return Results.NotFound();
    }

    List<BlogAuthor> blogAuthorsForAuthor1 = blogAuthors.Where(ba => ba.AuthorId == authorId).ToList();
    if (blogAuthorsForAuthor1 == null)
    {
        return Results.NotFound();
    }

    List<Blog> blogsFor1 = blogAuthorsForAuthor1.Select(ba => blogs.First(b => b.Id == ba.BlogId)).ToList();
    if (blogsFor1 == null)
    {
        return Results.NotFound();
    }

    author.Blogs = blogsFor1;
    return Results.Ok(author.Blogs);
});

//  Post new Blog
app.MapPost("/blogs", (Blog blog) =>
{
    blog.Id = blogs.Count > 0 ? blogs.Max(b => b.Id) + 1 : 1;
    blogs.Add(blog);
    return Results.Ok(blog);
});
#endregion

#region Endpoint--Articles
//  Get all Articles
app.MapGet("/articles", () => 
{
    return articles;
});

//  Get specific Article
app.MapGet("/articles/{id}", (int id) =>
{
    Article article = articles.FirstOrDefault(a => a.Id == id);
    if (article == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(article);
});

//  Get Articles for specific Blog
app.MapGet("/blogs/{blogId}/articles", (int blogId) =>
{
    //  Create list of articles with matching blogId
    List<Article> blogArticles = articles.Where(a => a.BlogId == blogId).ToList();
    if (blogArticles == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(blogArticles);
});

//  Get recently posted articles
app.MapGet("/articles/recent", () => 
{
    //  Create DateTime for past week
    DateTime oneWeekAgo = DateTime.Now - TimeSpan.FromDays(7);
    List<Article> recentArticles = articles.Where(a => a.DatePosted > oneWeekAgo).ToList();
    if (recentArticles == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(recentArticles);
});

//  Update an Article
app.MapPut("/articles/{id}", (int id, Article article) =>
{
    Article articleToUpdate = articles.FirstOrDefault(a => a.Id == id);
    int updateIndex = articleToUpdate.Id - 1;

    if (articleToUpdate == null)
    {
        return Results.NotFound();
    }

    articles[updateIndex] = article;
    return Results.Ok(article);
});

//  Update all Articles in a Blog
app.MapPut("blogs/{blogId}/articles", (int blogId, List<Article> articlesToUpdate) =>
{
    if (articlesToUpdate == null)
    {
        return Results.NotFound();
    }

    foreach (Article article in articlesToUpdate)
    {
        int updateIndex = articles.IndexOf(articles.FirstOrDefault(a => a.Id == article.Id));
        articles[updateIndex] = article;
    }

    return Results.Ok();
});

//  Delete all Articles for a Blog
app.MapDelete("/blogs/{blogId}/articles", (int blogId) =>
{
    //  Create list of blogs with matching blogId
    List<Article> blogArticles = articles.Where(a => a.BlogId == blogId).ToList();
    if (blogArticles == null)
    {
        return Results.NotFound();
    }

    foreach (Article article in blogArticles)
    {
        int indexToDelete = article.Id - 1;
        if (article.Id != articles[indexToDelete].Id)
        {
            indexToDelete = articles.IndexOf(articles.FirstOrDefault(a => a.Id == article.Id));
        }
        articles.RemoveAt(indexToDelete);
    }

    return Results.Ok();
});
#endregion

#region Endpoint--Comments
//  Get all Comments
app.MapGet("/comments", () =>
{
    return comments;
});

//  Get specific Comment
app.MapGet("/comments/{id}", (int id) =>
{
    Comment comment = comments.FirstOrDefault(c => c.Id == id);
    if (comment == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(comment);
});

//  Get Comments for a specific Article
app.MapGet("/articles/{articleId}/comments", (int articleId) =>
{
    List<Comment> articleComments = comments.Where(c => c.ArticleId == articleId).ToList();
    if (articleComments == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(articleComments);
});

//  Get all Comments on Articles on a Blog
app.MapGet("/blogs/{blogId}/articles/comments", (int blogId) =>
{
    //  Create list of articles with matching blogId
    List<Article> blogArticles = articles.Where(a => a.BlogId == blogId).ToList();
    if (blogArticles == null)
    {
        return Results.NotFound();
    }

    //  Iterate through each articles and get its comments
    foreach (Article article in blogArticles)
    {
        //  Create list of comments with matching articleId
        List<Comment> articleComments = comments.Where(c => c.ArticleId == article.Id).ToList();
        if (articleComments == null)
        {
            break;
        }
        article.Comments = articleComments;
    }

    return Results.Ok(blogArticles);
});

//  Get Comments by a specific Author
app.MapGet("authors/{authorId}/comments", (int authorId) =>
{
    List<Comment> authorComments = comments.Where(c => c.AuthorId == authorId).ToList();
    if (authorComments == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(authorComments);
});

//  Create Comment on a specific Article
app.MapPost("/articles/{articleId}/comments", (int articleId, Comment comment) =>
{
    comment.Id = comments.Count > 0 ? comments.Max(c => c.Id) + 1 : 1;
    comment.ArticleId = articleId;
    comments.Add(comment);

    return Results.Ok(comment);
});

//  Delete a specific Comment
app.MapDelete("/comments/{id}", (int id) =>
{
    comments.RemoveAt(id-1);
    return Results.Ok();
});
#endregion

#region Endpoint--Authors
//  Get all Authors
app.MapGet("/authors", () => 
{
    return authors;
});

//  Add Author to a Blog
app.MapPost("blogs/{blogId}/authors", (int blogId, Author author) =>
{
    //  Get list of current BlogAuthors
    List<BlogAuthor> currentBlogAuthors = blogAuthors.Where(ba => ba.BlogId == blogId).ToList();
    if (currentBlogAuthors == null)
    {
        return Results.NotFound();
    }

    //  If author is already included, return BadRequest
    foreach (BlogAuthor blogAuthor in currentBlogAuthors) 
    {
        if (blogAuthor.AuthorId == author.Id)
        {
            return Results.BadRequest();
        }
    }

    //  Create BlogAuthor and add to list
    BlogAuthor blogAuthorToAdd = new BlogAuthor()
    {
        Id = blogAuthors.Count > 0 ? blogAuthors.Max(ba => ba.Id) + 1 : 1,
        BlogId = blogId,
        AuthorId = author.Id
    };
    blogAuthors.Add(blogAuthorToAdd);

    return Results.Ok(blogAuthorToAdd);
});

#endregion

#region Endpoint--BlogAuthors
//  Get all BlogAuthors
app.MapGet("/blogauthors", () =>
{
    return blogAuthors;
});
#endregion

#endregion

app.Run();