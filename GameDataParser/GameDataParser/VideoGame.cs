using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser
{
    public class VideoGame
    {
        public string Title { get; init; }

        public int ReleaseYear { get; init; }

        public decimal Rating { get; init; }

        public override string ToString()
        {
            return Title.ToString() + " - " + "released in " + ReleaseYear.ToString() + " - " + "with a rating of: " + Rating.ToString();
        }
    }
}
