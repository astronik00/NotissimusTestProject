using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Xml.Models.DbRecords;
using Xml.Options;
using Xml.Repositories;
using Xml.Repositories.Offers;
using Xml.Services.Offers;

namespace Tests;

public class Tests
{
    private readonly ApplicationContext _applicationContext;
    private readonly IOffersService _offersService;

    public Tests()
    {
        var xmlOptions =
            JsonConvert.DeserializeObject<XmlReadFileOptions>(File.ReadAllText("JsonOptions/XmlSettings.json"))!;
        var dbOptions =
            JsonConvert.DeserializeObject<DbConnectionOptions>(File.ReadAllText("JsonOptions/DbSettings.json"))!;

        _applicationContext = new ApplicationContext(Options.Create(dbOptions));
        _offersService = new OffersService(new OffersContext(_applicationContext), Options.Create(xmlOptions));
    }

    [SetUp]
    public void Setup()
    {
    }

    private static OfferModel GetDemoOffer()
    {
        return new OfferModel
        {
            Id = 12344,
            Available = true,
            Description = " Dark Side Of The Moon, поставивший мир на уши невиданным сочетанием звуков, " +
                          "— это всего-навсего девять треков, и даже не все они писались специально " +
                          "для альбома. Порывшись по сусекам, участники Pink Floyd мудро сделали новое " +
                          "из хорошо забытого старого — песен, которые почему-либо не пошли в дело или " +
                          "остались незаконченными. Одним из источников вдохновения стали саундтреки для " +
                          "кинофильмов, которые группа производила в больших количествах.",
            Type = "artist.title",
            Bid = 11,
            Url = "http://magazin.ru/product_page.asp?pid=14347",
            Price = 450,
            CurrencyId = "RUR",
            CategoryId = new CategoryIdModel(17, "Own"),
            Picture = "http://magazin.ru/img/cd14347.jpg",
            Delivery = true,
            Artist = "Pink Floyd",
            Title = "Dark Side Of The Moon, Platinum Disc",
            Year = 1999,
            Media = "CD"
        };
    }

    [Test]
    public void TestCorrectAdd()
    {
        const int testId = 12344;

        if (_applicationContext.Offers.Any())
        {
            _offersService.AddOffer(testId).Wait();
            var testIdCount = _applicationContext.Offers.Count(_ => _.Id == testId);
            Assert.That(testIdCount, Is.EqualTo(1));
        }
        else
        {
            _offersService.AddOffer(testId);
            Assert.That(_applicationContext.Offers.Any(), Is.EqualTo(true));
        }
    }

    [Test]
    public void TestCorrectGettingOffer()
    {
        const int testId = 12344;
        Assert.That(GetDemoOffer(), Is.EqualTo(_offersService.GetOffer(testId).Result));
    }
}