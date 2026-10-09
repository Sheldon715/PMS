using System;
using System.Net.NetworkInformation;

namespace PMS.Models;

public class User
{
    public List<Order> Orders { get; private set; }
    public List<Payment> Payments { get; private set; }

    public User(List<Order> orders, List<Payment> payments)
    {
        Orders = orders;
        Payments = payments;
    }


    public Order GetMostExpensiveOrder()
    {
        return Orders.OrderByDescending(o => o.TotalPrice)
        .First();
    }

    public Order NewestOrder()
    {
        return Orders.OrderByDescending(o => o.CreatedAt)
        .First();
    }

    public Payment GetLowestPricePayment()
    {
        return Payments.OrderBy(p => p.PaymentAmount)
        .First();
    }

    public Payment NewestPayment()
    {
        return Payments.OrderByDescending(p => p.PaymentId)
        .First();
    }

    public IEnumerable<Payment> PaymentMoreThanTen()
    {
        return Payments.Where(p => p.PaymentAmount > 10);
    }
}
