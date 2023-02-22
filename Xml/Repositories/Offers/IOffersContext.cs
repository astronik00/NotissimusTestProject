using Xml.Models.DbRecords;

namespace Xml.Repositories.Offers;

public interface IOffersContext
{
    public void AddOffer(OfferModel offer);
    public OfferModel? GetOffer(int id);
}