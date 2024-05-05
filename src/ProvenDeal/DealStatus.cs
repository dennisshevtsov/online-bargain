using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvenDeal;

// 1. A merchant creates a new deal.                   NewDeal
// 2. A customer opens the deal.                       OpenDeal
// 3. The customer fills out details and sings on.     SignedDeal
// 4. The system reserves the total of the deal.       MoneyReserved
// 5. The merchant accepts the deal.                   WaitingForAcceptance
// 6. The customer accepts the deal.                   WaitingForAcceptance
// 7. The system transfers the total to the merchant.  Committed

public readonly record struct DealStatus(string Code)
{
  public static readonly DealStatus None;
  public static readonly DealStatus New       = new(Code: "New");
  public static readonly DealStatus Open      = new(Code: "Open");
  public static readonly DealStatus Reserved  = new(Code: "Reserved");
  public static readonly DealStatus Committed = new(Code: "Committed");
  public static readonly DealStatus Declined  = new(Code: "Declined");
  public static readonly DealStatus Cancelled = new(Code: "Cancelled");
}
