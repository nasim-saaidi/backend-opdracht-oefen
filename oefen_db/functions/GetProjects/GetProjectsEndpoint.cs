
namespace functions.GetAllProjects;

public static class GetProjectsEndpoint
{
    public static RouteHandlerBuilder MapGetProjectsEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapGet("", GetProjectsHandler.GetProjectsHandle)
        .WithName("GetProjects");
    }
}