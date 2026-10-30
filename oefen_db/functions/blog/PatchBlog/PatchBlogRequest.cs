using System.ComponentModel.DataAnnotations;

namespace functions.PatchBlog;

public sealed class PatchBlogRequest
{
    public string? Title{get; init;} 


    
        public string? Content{get; set;}


    public DateTime? Date{get; set;}

}