using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;
using Microsoft.Extensions.Options;
using Xml.Models;
using Xml.Models.DbRecords;
using Xml.Models.XmlRecords;
using Xml.Options;
using Xml.Repositories.Offers;

namespace Xml.Services.Offers;

public class OffersService : IOffersService
{
    private readonly IOffersContext _offersContext;
    private readonly XmlReadFileOptions _xmlReadFileOptions;
    private readonly XmlSerializer _xmlSerializer;

    public OffersService(IOffersContext offersContext, IOptions<XmlReadFileOptions> myOptions)
    {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        _offersContext = offersContext;
        _xmlReadFileOptions = myOptions.Value;
        _xmlSerializer = new XmlSerializer(typeof(OfferXmlModel));
    }

    public void AddOffer(int id)
    {
        var elements = XElement.Load(_xmlReadFileOptions.Url)
                               .Descendants("offer")
                               .First(_ => (int)_.Attribute("id")! == id)
                               .CreateReader();
        var offer = (OfferXmlModel)_xmlSerializer.Deserialize(elements)!;
        _offersContext.AddOffer(offer.CreateOfferRecord());
    }

    public OfferModel? GetOffer(int id)
    {
        return _offersContext.GetOffer(id);
    }
}