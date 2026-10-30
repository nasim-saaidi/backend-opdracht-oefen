namespace functions.PatchProject;

public static class PatchProjectEndpoint
{
    public static RouteHandlerBuilder MapPatchProjectEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapPatch("/{id:int}", PatchProjectHandler.PatchProjectHandle)
        .WithName("PatchProject");
    }
}