using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Xml.Models.DbRecords;

public class CategoryIdModel
{
    public CategoryIdModel()
    {
    }

    public CategoryIdModel(int id, string type)
    {
        Id = id;
        Type = type;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; init; }

    public string Type { get; init; }

    private bool Equals(CategoryIdModel other)
    {
        return Id == other.Id && Type == other.Type;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((CategoryIdModel)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Type);
    }
}