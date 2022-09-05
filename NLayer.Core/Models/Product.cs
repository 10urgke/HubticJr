// ReSharper disable All
namespace NLayer.Core;

public class Product:BaseEntity
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } //Navigation Property Producttan Categorye gidebiliriz.
    public ProductFeature ProductFeature { get; set; } //Navigation Property Producttan ProductFeaturea gidebiliriz. ALTININ SARI ÇİZGİ OLMASININ SEBEBİ NULL OLABİLİYOR OLMASI!!!
    
}