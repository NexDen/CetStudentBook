
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CetStudentBook.Models;

public class Book
{
    public int Id { get; set; }
    [Required, StringLength(200, MinimumLength = 2)] public string Name { get; set; }
    [Required, StringLength(200, MinimumLength = 2)] public string Author { get; set; }
    [Required, DisplayName("Publish Date")] public DateTime PublishDate { get; set; }
    [Required, Range(1,1000), DisplayName("Page Count")] public int PageCount  { get; set; }
    [Required, DisplayName("Is Second Hand")] public bool IsSecondHand { get; set; }
}