using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using functions.CreateProject;
using functions.GetAllProjects;
using functions.DeleteProject;
using functions.GetProject;
using functions.UpdateProject;
using functions.CreateBlog;
using functions.GetAllBlogs;
using functions.DeleteBlog;
using functions.GetBlog;
using functions.UpdateBlog;
using functions.PatchProject;
using functions.PatchBlog;


namespace functions.Endpoint;

public static class Endpoints
{
    public static IEndpointRouteBuilder  MapAllEndpoints(this IEndpointRouteBuilder endpoints)
    {
        RouteGroupBuilder projectGroup = endpoints.MapGroup("/projects");
        RouteGroupBuilder blogGroup = endpoints.MapGroup("/blogs");

        projectGroup.MapCreateProjectEndpoint();
        projectGroup.MapGetProjectsEndpoint();
        projectGroup.MapDeleteProjectEndpoint();
        projectGroup.MapGetProjectEndpoint();
        projectGroup.MapUpdateProjectEndpoint();
        projectGroup.MapPatchProjectEndpoint();
        blogGroup.MapCreateBlogEndpoint();
        blogGroup.MapGetBlogsEndpoint();
        blogGroup.MapDeleteBlogEndpoint();
        blogGroup.MapGetBlogEndpoint();
        blogGroup.MapUpdateBlogEndpoint();
        blogGroup.MapPatchBlogEndpoint();

        return endpoints;
    }
}


