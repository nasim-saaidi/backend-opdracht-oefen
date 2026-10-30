using Microsoft.AspNetCore.Components.Web;

namespace functions.GetBlog;
public sealed record class GetBlogResponse(int id, string Title, string Content, DateTime Date);