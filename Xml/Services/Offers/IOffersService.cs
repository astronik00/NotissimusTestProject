using Xml.Models.DbRecords;

namespace Xml.Services.Offers;

public interface IOffersService
{
    public Task AddOffer(int id, CancellationToken token = default);
    public Task<OfferModel?> GetOffer(int id, CancellationToken token = default);
}