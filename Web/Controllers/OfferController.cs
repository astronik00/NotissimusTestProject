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
    public ViewResult Index()
    {
        const int offerId = 12344;
        OffersService.AddOffer(offerId);
        return View("Offer", OffersService.GetOffer(offerId));
    }
}