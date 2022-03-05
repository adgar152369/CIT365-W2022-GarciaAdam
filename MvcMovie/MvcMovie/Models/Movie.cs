namespace MvcMovie.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Movie
{
    // Id field required for primary key in the database
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Title { get; set; }   

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    // ? indicates the property is nullable
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    public string? Genre { get; set; }

    [Range(1, 100)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }


    public string? Rating { get; set; }

    [Display(Name = "Image")]
    public string ImagePath { get; set; }

}
