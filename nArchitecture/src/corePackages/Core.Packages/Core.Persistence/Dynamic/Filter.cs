using System.Reflection.Metadata;

namespace Core.Persistence.Dynamic;

public class Filter
{
    /// <summary>
    /// The field to filter by.
    /// </summary>
    public string Field { get; set; }

    /// <summary>
    /// Filed Value
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// The operator used in the comparison (e.g., '=', '>', '<').
    /// </summary>
    public string? Operator { get; set; }

    /// <summary>    
    /// Logical operation to combine multiple filters (e.g., 'AND', 'OR').
    /// </summary>
    public string? Logic { get; set; }


    public IEnumerable<Filter> Filters { get; set; }

    public Filter()
    {
        Field = string.Empty;
        Operator = string.Empty;
    }

    public Filter(string field, string @operator)
    {
        Field = field;
        Operator = @operator;
    }
}
