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

        
        project.Title = request.Title;
        project.Description = request.Description;
        project.Category = request.Category;
        project.Date = request.Date;
        project.Repo_link = request.Repo_link;
        project.Img_alt = request.Img_alt;
        project.Img_src = request.Img_src;
        await dbContext.SaveChangesAsync(cancellationToken);

       return TypedResults.Ok(project);
    }
}