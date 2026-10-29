using Microsoft.EntityFrameworkCore;
using main.db;

namespace functions.UpdateProject;

public static class UpdateProjectHandler
{
    public static async Task<IResult> UpdateProjectHandle(
        int id, UpdateProjectRequest request, OefenDB dbContext, 
        CancellationToken cancellationToken
    )
    {
        var project = await dbContext.Projects
        .FirstOrDefaultAsync(project => project.Id == id, cancellationToken);

        if(project is null)
        {
            return TypedResults.NotFound();
        }

        project.Repo_link = request.Repo_link;
        project.Title = request.Title;
        project.Img_alt = request.Img_alt;
        project.Img_src = request.Img_src;
        project.Description = request.Description;
        await dbContext.SaveChangesAsync(cancellationToken);

       return TypedResults.Ok(project);
    }
}