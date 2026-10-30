using Microsoft.EntityFrameworkCore;
using main.db;

namespace functions.PatchBlog;

public static class PatchBlogHandler
{
    public static async Task<IResult> PatchBlogHandle(
        int id, PatchBlogRequest request, OefenDB dbContext, 
        CancellationToken cancellationToken
    )
    {
        var blog = await dbContext.Blogs
        .FindAsync(id);

        if(blog is null)
        {
            return TypedResults.NotFound();
        }

        if(request.Title is not null) blog.Title = request.Title;
        if(request.Content is not null) blog.Content = request.Content;
        if(request.Date.HasValue) blog.Date = request.Date.Value;

        await dbContext.SaveChangesAsync(cancellationToken);

       return TypedResults.NoContent();
    }
}