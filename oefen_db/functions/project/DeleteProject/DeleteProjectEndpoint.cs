

namespace functions.DeleteProject;

public static class DeleteProjectEndpoint
{
    public static RouteHandlerBuilder MapDeleteProjectEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapDelete("/{id:int}", DeleteProjectHandler.DeleteProjectHandle)
        .WithName("DeleteProject");
    }
}