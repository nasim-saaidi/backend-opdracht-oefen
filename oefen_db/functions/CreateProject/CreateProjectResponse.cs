using Microsoft.AspNetCore.Components.Web;

namespace functions.CreateProject;
public sealed record class CreateProjectResponse(int id, string Repo_link, string Title, String Img_alt, string Img_src, String Description);