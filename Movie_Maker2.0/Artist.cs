using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Movie_Maker2._0
{
    class Artist
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Cache { get; set; }
        public double PercentDiscount { get; set; }
        public int Amount { get; set; }

        public Artist(int Code, string Name, double Cache, double PercentDiscount, int Amount)
        {
            this.Code = Code;
            this.Name = Name;
            this.Cache = Cache;
            this.PercentDiscount = PercentDiscount;
            this.Amount = Amount;
        }

        public override string ToString()
        {
            return "Code: "
                + Code
                + ", Name: "
                + Name
                + ", Cache: $"
                + Cache.ToString("F2", CultureInfo.InvariantCulture)
                + ", PercentDiscount: "
                + PercentDiscount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}