using Microsoft.AspNetCore.Components.Web;

namespace functions.CreateProject;
public sealed record class CreateProjectResponse(int id, string Title, string Description, string Category, DateOnly Date, string Repo_link,  string Img_alt, string Img_src);