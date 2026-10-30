using main.db;
using Microsoft.EntityFrameworkCore;

namespace functions.GetAllProjects;

public static class GetProjectsHandler

{
    public static async Task<IResult> GetProjectsHandle(
         OefenDB dbContext, CancellationToken cancellationToken)
    {
        var projects = await dbContext.Projects
        .AsNoTracking()
        .OrderBy(project => project.Id)
        .Select(project => new GetProjectsResponse(project.Id, project.Title, project.Description, project.Category, project.Date, project.Repo_link,  project.Img_alt, project.Img_src))
        .ToListAsync(cancellationToken);
        return TypedResults.Ok(projects);
    }
    
}