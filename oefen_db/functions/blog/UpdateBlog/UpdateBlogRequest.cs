using System.ComponentModel.DataAnnotations;

namespace functions.UpdateBlog;

public sealed class UpdateBlogRequest
{

      [Required]
    public string Title{get; init;} = string.Empty;

    
    [Required]
    
        public string Content{get; set;} = string.Empty;

    [Required]
    
    public DateTime Date{get; set;}

}