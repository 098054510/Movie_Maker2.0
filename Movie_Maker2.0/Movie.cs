﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Maker2._0
{
    class Movie
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public Artist artist { get; set; }

        public Movie(int Code, string Title, Artist artist)
        {
            this.Code = Code;
            this.Title = Title;
            this.artist = artist;
        }


        public override string ToString()
        {
            return "Code: "
                + Code
                + ", Title: "
                + Title
                + ", Main Artist: "
                + artist;
        }
    }
}
