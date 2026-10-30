using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace functions.GetProject;

public static class GetProjectEndpoint
{
    public static RouteHandlerBuilder MapGetProjectEndpoint(this RouteGroupBuilder routeGroupBuilder)
    {
        return routeGroupBuilder.MapGet("/{id:int}", GetProjectHandler.GetProjectHandle)
            .WithName("GetProject");
    }
}