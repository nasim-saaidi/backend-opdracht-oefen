

namespace functions.DeleteBlog;

public static class DeleteBlogEndpoint
{
    public static RouteHandlerBuilder MapDeleteBlogEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapDelete("/{id:int}", DeleteBlogHandler.DeleteBlogHandle)
        .WithName("DeleteBlog");
    }
}