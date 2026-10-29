namespace functions.GetProject;



public sealed record class GetProjectResponse(int id, string Repo_link, string Title, string Img_alt, string Img_src, string Description);