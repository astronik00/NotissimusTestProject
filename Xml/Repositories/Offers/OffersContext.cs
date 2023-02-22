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

    public void AddOffer(OfferModel offer)
    {
        if (_applicationContext.Offers
                               .AsQueryable()
                               .Any(_ => _.Id == offer.Id))
            return;

        _applicationContext.Offers.Add(offer);
        _applicationContext.SaveChanges();
    }

    public OfferModel? GetOffer(int id)
    {
        return _applicationContext.Offers
                                  .AsQueryable()
                                  .Include(_ => _.CategoryId)
                                  .FirstOrDefault(_ => _.Id == id);
    }
}