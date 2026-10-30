using Microsoft.EntityFrameworkCore;
using main.db;

namespace functions.PatchProject;

public static class PatchProjectHandler
{
    public static async Task<IResult> PatchProjectHandle(
        int id, PatchProjectRequest request, OefenDB dbContext, 
        CancellationToken cancellationToken
    )
    {
        var project = await dbContext.Projects
        .FindAsync(id);

        if(project is null)
        {
            return TypedResults.NotFound();
        }

        if(request.Title is not null) project.Title = request.Title;
        if(request.Description is not null) project.Description = request.Description;
        if(request.Category is not null) project.Category = request.Category;
        if(request.Date.HasValue) project.Date = request.Date.Value;
        if(request.Repo_link is not null) project.Repo_link = request.Repo_link;
        if(request.Img_alt is not null) project.Img_alt = request.Img_alt;
        if(request.Img_src is not null) project.Img_src = request.Img_src;

        await dbContext.SaveChangesAsync(cancellationToken);

       return TypedResults.NoContent();
    }
}