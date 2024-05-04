namespace ProvenDeal.Web.Dtos;

public sealed class DealDto
{
  public required string Description { get; set; }

  public required string Customer { get; set; }

  public required string Executor { get; set; }

  public required decimal Sum { get; set; }
}
