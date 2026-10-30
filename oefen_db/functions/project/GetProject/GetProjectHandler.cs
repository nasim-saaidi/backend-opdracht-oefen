using Microsoft.EntityFrameworkCore;
using main.db;

namespace functions.GetProject;

public static class GetProjectHandler
{
    public static async Task<IResult> GetProjectHandle(
        int id, OefenDB dbContext, CancellationToken cancellationToken)
    {
        var project = await dbContext.Projects
        .Where(project => project.Id == id)
        .Select(project => new GetProjectResponse(project.Id, project.Title, project.Description, project.Category, project.Date, project.Repo_link,  project.Img_alt, project.Img_src))
        .AsNoTracking()
        .FirstOrDefaultAsync(cancellationToken);

        return project is null ? TypedResults.NotFound() : TypedResults.Ok(project);
    }
    
}


