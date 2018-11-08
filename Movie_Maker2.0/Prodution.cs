using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Movie_Maker2._0
{
    class Prodution
    {
        public int Code { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Artist artist { get; set; }
        public Movie movie { get; set; }
        public static List<Prodution> prodution = new List<Prodution>();

        public Prodution(int Code, int Day, int Mounth, int Year, Artist artist, Movie movie)
        {
            this.Code = Code;
            ReleaseDate = new DateTime(Year, Mounth, Day);
            this.artist = artist;
            this.movie = movie;
            prodution = new List<Prodution>();
        }

        public double SubTotal()
        {
            double Discount = artist.Cache * artist.PercentDiscount / 100.0;
            return (artist.Cache * Discount) * artist.Amount;
        }

        public double FullValor()
        {
            double sum = 0.0;
            for (int i = 0; i<prodution.Count; i++)
            {
                sum = sum + prodution[i].SubTotal();
            }
            return sum;
        }
    }
}