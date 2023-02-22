using System.Xml.Serialization;

namespace Xml.Models.XmlRecords;

[Serializable]
[XmlRoot("offer")]
public class OfferXmlModel
{
    public OfferXmlModel()
    {
    }

    public OfferXmlModel(int id, string type, int bid, bool available,
                         string url, decimal price, string currencyId,
                         CategoryIdXmlModel categoryIdXml, string picture,
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
        CategoryIdXml = categoryIdXml;
        Picture = picture;
        Delivery = delivery;
        Artist = artist;
        Title = title;
        Year = year;
        Media = media;
        Description = description;
    }

    [XmlAttribute(AttributeName = "id")] public int Id { get; set; }

    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }

    [XmlAttribute(AttributeName = "bid")] public int Bid { get; set; }

    [XmlAttribute(AttributeName = "available")]
    public bool Available { get; set; }

    [XmlElement(ElementName = "url")] public string Url { get; set; }

    [XmlElement(ElementName = "price")] public decimal Price { get; set; }

    [XmlElement(ElementName = "currencyId")]
    public string CurrencyId { get; set; }

    [XmlElement(ElementName = "categoryId")]
    public CategoryIdXmlModel CategoryIdXml { get; set; }

    [XmlElement(ElementName = "picture")] public string Picture { get; set; }

    [XmlElement(ElementName = "delivery")] public bool Delivery { get; set; }

    [XmlElement(ElementName = "artist")] public string Artist { get; set; }

    [XmlElement(ElementName = "title")] public string Title { get; set; }

    [XmlElement(ElementName = "year")] public int Year { get; set; }

    [XmlElement(ElementName = "media")] public string Media { get; set; }

    [XmlElement(ElementName = "description")]
    public string Description { get; set; }
}