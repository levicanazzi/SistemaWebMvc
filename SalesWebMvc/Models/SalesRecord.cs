using System;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Saller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(DateTime date, double amount, SalesStatus status, Seller saller)
        {
            Date = date;
            Amount = amount;
            Status = status;
            Saller = saller;
        }
    }
}
