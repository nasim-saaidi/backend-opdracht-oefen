using main.db;
using Models.blog;

namespace functions.CreateBlog;

public static class CreateBlogHandler

{
    public static async Task<IResult> CreateBlogHandle(
        CreateBlogRequest request, OefenDB dbContext, CancellationToken cancellationToken)
    {
        var blog = new Blog { Title = request.Title,  Content = request.Content, Date = request.Date};
        dbContext.Blogs.Add(blog);
        await dbContext.SaveChangesAsync(cancellationToken);

        var response = new CreateBlogResponse(blog.Id, blog.Title, blog.Content, blog.Date);
        return TypedResults.CreatedAtRoute(
            response,
            routeName: "GetBlog",
            routeValues: new { id = blog.Id });
    }
    
}