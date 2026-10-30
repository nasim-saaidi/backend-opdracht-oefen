namespace functions.GetAllBlogs;



public sealed record class GetBlogsResponse(int id, string Title, string Content, DateTime Date);