using Xml.Models.DbRecords;

namespace Xml.Services.Offers;

public interface IOffersService
{
    public void AddOffer(int id);
    public OfferModel? GetOffer(int id);
}