using TestAssignment.Infrastructure;

namespace TestAssignment.Areas.Data;

public class Product : EntityBase
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal Quantiy { get; set; }
}
