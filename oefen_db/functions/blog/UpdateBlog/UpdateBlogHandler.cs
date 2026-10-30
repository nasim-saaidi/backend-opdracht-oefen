using Microsoft.EntityFrameworkCore;
using main.db;

namespace functions.UpdateBlog;

public static class UpdateBlogHandler
{
    public static async Task<IResult> UpdateBlogHandle(
        int id, UpdateBlogRequest request, OefenDB dbContext, 
        CancellationToken cancellationToken
    )
    {
        var blog = await dbContext.Blogs
        .FirstOrDefaultAsync(blog => blog.Id == id, cancellationToken);

        if(blog is null)
        {
            return TypedResults.NotFound();
        }

        
        blog.Title = request.Title;
        blog.Content = request.Content;
        blog.Date = request.Date;
        await dbContext.SaveChangesAsync(cancellationToken);

       return TypedResults.Ok(blog);
    }
}