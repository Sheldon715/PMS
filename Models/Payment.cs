using System;
using PMS.Enums;

namespace PMS.Models;

public class Payment
{
    public Order Order { get; private set; }
    public int PaymentId { get; private set; }
    PaymentStatus Status;
    public decimal PaymentAmount { get; private set; }
    PaymentMethod Method;
    public User User { get; private set; }

}
