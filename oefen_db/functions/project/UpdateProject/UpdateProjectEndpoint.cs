namespace functions.UpdateProject;

public static class UpdateProjectEndpoint
{
    public static RouteHandlerBuilder MapUpdateProjectEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapPut("/{id:int}", UpdateProjectHandler.UpdateProjectHandle)
        .WithName("UpdateProject");
    }
}