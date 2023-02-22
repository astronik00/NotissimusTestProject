using System.Xml.Serialization;

namespace Xml.Models.XmlRecords;

[Serializable]
[XmlRoot("offer")]
public class CategoryIdXmlModel
{
    public CategoryIdXmlModel()
    {
    }

    public CategoryIdXmlModel(int id, string type)
    {
        Id = id;
        Type = type;
    }

    [XmlText] public int Id { get; set; }

    [XmlAttribute(AttributeName = "type")] public string Type { get; set; }
}