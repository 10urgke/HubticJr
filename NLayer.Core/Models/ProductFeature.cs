// ReSharper disable All
namespace NLayer.Core;

public class ProductFeature
{
    public int Id { get; set; }
    public string Color { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public int ProductId { get; set; } //Hangi product feature hangi producta ait burdan belli olacak.
    public Product Product { get; set; }
}