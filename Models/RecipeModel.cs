using System.ComponentModel.DataAnnotations;
namespace RecipeApp.Models;

public class Recipe{
    public required int Id { get; set; }
    public required string Title { get; set; }
    public string? Image {get; set;}
    public required string[] Ingredients { get; set; }
    public required string Description { get; set; }
    public required string[] Tags { get; set; }
    private DateOnly _publishDate;

    //[DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString ="{0:MM dd, yyyy}")]
    

    public required DateOnly PublishDate {get;
set;}

}
