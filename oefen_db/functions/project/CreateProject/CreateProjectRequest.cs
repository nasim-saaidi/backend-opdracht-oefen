using System.ComponentModel.DataAnnotations;

namespace functions.CreateProject;

public sealed class CreateProjectRequest
{

      [Required]
    public string Title{get; init;} = string.Empty;

    
    [Required]
    
    public string Description{get; init;} = string.Empty;

    [Required]
    
    public string Category{get; init;} = string.Empty;

    [Required]
    
    public DateOnly Date{get; init;}


    [Required]
    public string Repo_link {get; init;} = string.Empty;

  

    [Required]
    public string Img_alt{get; init;} = string.Empty;

    [Required]
    public string Img_src{get; init;} = string.Empty;

}