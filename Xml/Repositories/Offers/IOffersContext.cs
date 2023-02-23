using Xml.Models.DbRecords;

namespace Xml.Repositories.Offers;

public interface IOffersContext
{
    public Task AddOffer(OfferModel offer, CancellationToken token = default);
    public Task<OfferModel?> GetOffer(int id, CancellationToken token = default);
}