using Microsoft.EntityFrameworkCore;
using main.db;

namespace functions.DeleteBlog;

public static class DeleteBlogHandler
{
    public static async Task<IResult> DeleteBlogHandle(
        int id, OefenDB dbContext, CancellationToken cancellationToken)
    {
     var blog = await dbContext.Blogs.FirstOrDefaultAsync(blog => blog.Id == id, cancellationToken);

     if(blog is null)
        {
            return TypedResults.NotFound();
        }   
        dbContext.Blogs.Remove(blog);   
        await dbContext.SaveChangesAsync(cancellationToken);
        return TypedResults.NoContent();
    }
}