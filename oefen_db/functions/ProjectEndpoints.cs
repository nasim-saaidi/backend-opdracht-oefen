using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using functions.CreateProject;
using functions.GetAllProjects;
using functions.DeleteProject;
using functions.GetProject;
using functions.UpdateProject;

namespace functions.Endpoint;

public static class ProjectEndpoints
{
    public static RouteGroupBuilder MapAllProjectsEndpoints(this IEndpointRouteBuilder endpoints)
    {
        RouteGroupBuilder projectGroup = endpoints.MapGroup("/projects");

        projectGroup.MapCreateProjectEndpoint();
        projectGroup.MapGetProjectsEndpoint();
        projectGroup.MapDeleteProjectEndpoint();
        projectGroup.MapGetProjectEndpoint();
        projectGroup.MapUpdateProjectEndpoint();

        return projectGroup;
    }
}