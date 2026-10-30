
namespace functions.GetAllBlogs;

public static class GetBlogsEndpoint
{
    public static RouteHandlerBuilder MapGetBlogsEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapGet("", GetBlogsHandler.GetBlogsHandle)
        .WithName("GetBlogs");
    }
}