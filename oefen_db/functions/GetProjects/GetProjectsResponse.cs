namespace functions.GetAllProjects;



public sealed record class GetProjectsResponse(int id, string Repo_link, string Title, String Img_alt, string Img_src, String Description);