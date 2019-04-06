public class Binnacle
{
    public int Id { get; set; }
    public string Title { get; set; }

    [Display(Name = "Release Date")] // Nombre que se mostrara en el label
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}
