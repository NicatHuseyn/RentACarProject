namespace Core.Persistence.Dynamic;

public class Sort
{
    /// <summary>
    /// The field (property) to apply sorting on. 
    /// This should correspond to a property in the data model.
    /// </summary>
    public string Field { get; set; }

    /// <summary>
    /// The direction of the sorting. Can be "asc" for ascending or "desc" for descending.
    /// </summary>
    public string Direction { get; set; }

    public Sort()
    {
        Field = string.Empty;
        Direction = string.Empty;
    }

    public Sort(string field, string direction)
    {
        Field = field;
        Direction = direction;
    }
}
