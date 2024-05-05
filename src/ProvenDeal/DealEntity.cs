using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvenDeal;

public sealed class DealEntity
{
  public required Guid DealId { get; set; }

  public required string Description { get; set; }
}
