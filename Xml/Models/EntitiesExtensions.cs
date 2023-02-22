using Xml.Models.DbRecords;
using Xml.Models.XmlRecords;

namespace Xml.Models;

public static class EntitiesExtensions
{
    public static OfferModel CreateOfferRecord(this OfferXmlModel offerXmlModel)
    {
        return new OfferModel
        {
            Id = offerXmlModel.Id,
            Type = offerXmlModel.Type,
            Bid = offerXmlModel.Bid,
            Available = offerXmlModel.Available,
            Url = offerXmlModel.Url,
            Price = offerXmlModel.Price,
            CurrencyId = offerXmlModel.CurrencyId,
            CategoryId = offerXmlModel.CategoryIdXml.CreateCategoryIdRecord(),
            Picture = offerXmlModel.Picture,
            Delivery = offerXmlModel.Delivery,
            Artist = offerXmlModel.Artist,
            Title = offerXmlModel.Title,
            Year = offerXmlModel.Year,
            Media = offerXmlModel.Media,
            Description = offerXmlModel.Description
        };
    }

    private static CategoryIdModel CreateCategoryIdRecord(this CategoryIdXmlModel categoryIdXmlModel)
    {
        return new CategoryIdModel
        {
            Id = categoryIdXmlModel.Id,
            Type = categoryIdXmlModel.Type
        };
    }
}