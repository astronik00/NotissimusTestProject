using Microsoft.EntityFrameworkCore;
using Xml.Models.DbRecords;

namespace Xml.Repositories.Offers;

public class OffersContext : IOffersContext
{
    private readonly ApplicationContext _applicationContext;

    public OffersContext(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task AddOffer(OfferModel offer, CancellationToken token)
    {
        if (await _applicationContext.Offers
                               .AsQueryable()
                               .AnyAsync(_ => _.Id == offer.Id, token))
            return;

        await _applicationContext.Offers.AddAsync(offer, token);
        await _applicationContext.SaveChangesAsync(token);
    }

    public async Task<OfferModel?> GetOffer(int id, CancellationToken token)
    {
        return await _applicationContext.Offers
                                        .AsQueryable()
                                        .Include(_ => _.CategoryId)
                                        .FirstAsync(_ => _.Id == id, token);
    }
}