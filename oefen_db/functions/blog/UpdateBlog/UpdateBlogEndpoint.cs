namespace functions.UpdateBlog;

public static class UpdateBlogEndpoint
{
    public static RouteHandlerBuilder MapUpdateBlogEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapPut("/{id:int}", UpdateBlogHandler.UpdateBlogHandle)
        .WithName("UpdateBlog");
    }
}