using main.db;
using Models.project;

namespace functions.CreateProject;

public static class CreateProjectHandler

{
    public static async Task<IResult> CreateProjectHandle(
        CreateProjectRequest request, OefenDB dbContext, CancellationToken cancellationToken)
    {
        var project = new Project { Title = request.Title,  Description = request.Description, Category = request.Category, Date = request.Date, Repo_link = request.Repo_link,  Img_alt = request.Img_alt, Img_src = request.Img_src };
        dbContext.Projects.Add(project);
        await dbContext.SaveChangesAsync(cancellationToken);

        var response = new CreateProjectResponse(project.Id, project.Title, project.Description, project.Category, project.Date, project.Repo_link,  project.Img_alt, project.Img_src);
        return TypedResults.CreatedAtRoute(
            response,
            routeName: "GetProject",
            routeValues: new { id = project.Id });
    }
    
}