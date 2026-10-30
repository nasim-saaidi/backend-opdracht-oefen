namespace functions.GetProject;



public sealed record class GetProjectResponse(int id, string Title, string Description, string Category, DateOnly Date, string Repo_link,  string Img_alt, string Img_src);