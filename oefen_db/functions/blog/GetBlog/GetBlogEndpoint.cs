using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace functions.GetBlog;

public static class GetBlogEndpoint
{
    public static RouteHandlerBuilder MapGetBlogEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapGet("/{id:int}", GetBlogHandler.GetBlogHandle)
            .WithName("GetBlog");
    }
}