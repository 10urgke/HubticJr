// ReSharper disable All
namespace NLayer.Core;

public class Category:BaseEntity
{
    public string Name { get; set; }
    public ICollection<Product> Product { get; set; } //Navigation Property Çünkü; Kategoriden Productlara gidebilir.Yani kategorilere bağlı productları çekebilirim.

}