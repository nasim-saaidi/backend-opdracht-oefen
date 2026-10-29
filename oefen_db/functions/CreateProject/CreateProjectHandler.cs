using main.db;
using Models.project;

namespace functions.CreateProject;

public static class CreateProjectHandler

{
    public static async Task<IResult> CreateProjectHandle(
        CreateProjectRequest request, OefenDB dbContext, CancellationToken cancellationToken)
    {
        var project = new Project { Repo_link = request.Repo_link, Title = request.Title, Img_alt = request.Img_alt, Img_src = request.Img_src, Description = request.Description };
        dbContext.Projects.Add(project);
        await dbContext.SaveChangesAsync(cancellationToken);

        var response = new CreateProjectResponse(project.Id, project.Repo_link, project.Title, project.Img_alt, project.Img_src, project.Description);
        return TypedResults.CreatedAtRoute(
            response,
            routeName: "GetProject",
            routeValues: new { id = project.Id });
    }
    
}