using Microsoft.EntityFrameworkCore;
using main.db;

namespace functions.GetBlog;

public static class GetBlogHandler
{
    public static async Task<IResult> GetBlogHandle(
        int id, OefenDB dbContext, CancellationToken cancellationToken)
    {
        var blog = await dbContext.Blogs
        .Where(blog => blog.Id == id)
        .Select(blog => new GetBlogResponse(blog.Id, blog.Title, blog.Content, blog.Date))
        .AsNoTracking()
        .FirstOrDefaultAsync(cancellationToken);

        return blog is null ? TypedResults.NotFound() : TypedResults.Ok(blog);
    }
    
}


