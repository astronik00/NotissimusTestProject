using Microsoft.AspNetCore.Mvc;
using Xml.Services.Offers;

namespace NotissimusTestProject.Controllers;

[Route("")]
public class OfferController : Controller
{
    public OfferController(IOffersService offersService)
    {
        OffersService = offersService;
    }

    private IOffersService OffersService { get; }

    [HttpGet("/")]
    public async Task<ViewResult> GetOfferAsync(CancellationToken token)
    {
        const int offerId = 12344;
        await OffersService.AddOffer(offerId, token);
        return View("Offer", await OffersService.GetOffer(offerId, token));
    }
}