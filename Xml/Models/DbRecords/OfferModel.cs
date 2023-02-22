using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Xml.Models.DbRecords;

public class OfferModel
{
    public OfferModel()
    {
    }

    public OfferModel(int id, string type, int bid, bool available,
                      string url, decimal price, string currencyId,
                      CategoryIdModel categoryId, string picture,
                      bool delivery, string artist, string title,
                      int year, string media, string description)
    {
        Id = id;
        Type = type;
        Bid = bid;
        Available = available;
        Url = url;
        Price = price;
        CurrencyId = currencyId;
        CategoryId = categoryId;
        Picture = picture;
        Delivery = delivery;
        Artist = artist;
        Title = title;
        Year = year;
        Media = media;
        Description = description;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; init; }

    public string Type { get; set; }

    public int Bid { get; set; }

    public bool Available { get; set; }

    public string Url { get; set; }

    public decimal Price { get; set; }

    public string CurrencyId { get; set; }

    public CategoryIdModel CategoryId { get; set; }

    public string Picture { get; set; }

    public bool Delivery { get; set; }

    public string Artist { get; set; }

    public string Title { get; set; }

    public int Year { get; set; }

    public string Media { get; set; }

    public string Description { get; set; }

    private bool Equals(OfferModel other)
    {
        return Id == other.Id && Type == other.Type && Bid == other.Bid
            && Available == other.Available && Url == other.Url
            && Price == other.Price && CurrencyId == other.CurrencyId
            && CategoryId.Equals(other.CategoryId) && Picture == other.Picture
            && Delivery == other.Delivery && Artist == other.Artist
            && Title == other.Title && Year == other.Year && Media == other.Media
            && Description == other.Description;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((OfferModel)obj);
    }

    public override int GetHashCode()
    {
        var hashCode = new HashCode();
        hashCode.Add(Id);
        hashCode.Add(Type);
        hashCode.Add(Bid);
        hashCode.Add(Available);
        hashCode.Add(Url);
        hashCode.Add(Price);
        hashCode.Add(CurrencyId);
        hashCode.Add(CategoryId);
        hashCode.Add(Picture);
        hashCode.Add(Delivery);
        hashCode.Add(Artist);
        hashCode.Add(Title);
        hashCode.Add(Year);
        hashCode.Add(Media);
        hashCode.Add(Description);
        return hashCode.ToHashCode();
    }
}