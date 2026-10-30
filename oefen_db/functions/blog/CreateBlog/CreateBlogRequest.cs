using System.ComponentModel.DataAnnotations;

namespace functions.CreateBlog;

public sealed class CreateBlogRequest
{

      [Required]
    public string Title{get; init;} = string.Empty;

    
    [Required]
    
        public string Content{get; set;} = string.Empty;

    [Required]
    
    public DateTime Date{get; set;}

}