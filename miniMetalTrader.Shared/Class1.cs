using System;
using System.Collections;
using System.Collections.Generic;

namespace miniMetalTrader.Shared
{
    public enum OrderTypes
    {
        Buy,
        Sell
    }

    public enum PositionStatus
    {
        Creating,
        Created,
        Submitted,
        Rejected,
        Executing,
        Filled,
        Cancelled,
        Reveresed
    }

    public class Client
    {
        public string ClientId { get; set; }
        public string Name { get; set; }
        public Account Account { get; set; }
    }

    public class Account
    {
        public string Id { get; set; }
        public List<IPosition> Positions { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
    }

    public interface IPosition{
        public long PositionId { get; set; }
        public OrderTypes OrderType { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public Instrument Instrument { get; set; }
        public PositionStatus Status { get; set; }
    }

    public class Order : IPosition
    {
        public decimal Value()
        {
            return (Price * Quantity);
        }
        public OrderTypes OrderType { get ; set ; }
        public decimal Quantity { get ; set ; }
        public decimal Price { get ; set ; }
        public Instrument Instrument { get ; set ; }
        public PositionStatus Status { get; set; }
        public long PositionId { get ; set ; }
    }

    public class Transaction : IPosition
    {
        public OrderTypes OrderType { get ; set ; }
        public decimal Quantity { get ; set ; }
        public decimal Price { get ; set ; }
        
        public PositionStatus Status { get ; set ; }
        public long PositionId { get ; set ; }
        public Instrument Instrument { get; set; }

        // transaction is any order that has state Filled/Reversed

    }

    public class Instrument
    {
        public override string ToString()
        {
            return this.Ticker;
        }
        public string ISIN { get; set; }
        public string Ticker { get; set; }
        public string Description { get; set; }
        public DateTime ValueDate { get; set; }
        public decimal Price { get; set; }
        public decimal MinBuyOrder { get; set; } = 1;
    }

    public class FXRate
    {
        public string Base { get; set; }
        public string To { get; set; }
        public decimal Rate { get; set; }
        public DateTime ValueDate { get; set; }
    }
}
