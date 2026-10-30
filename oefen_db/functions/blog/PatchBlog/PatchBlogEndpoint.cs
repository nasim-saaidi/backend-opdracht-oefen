namespace functions.PatchBlog;

public static class PatchBlogEndpoint
{
    public static RouteHandlerBuilder MapPatchBlogEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapPatch("/{id:int}", PatchBlogHandler.PatchBlogHandle)
        .WithName("PatchBlog");
    }
}