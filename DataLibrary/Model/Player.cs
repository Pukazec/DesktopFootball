using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    public class Player
    {
        private static readonly char DEL = '|';

        public enum PositionE { Defender, Forward, Goalie, Midfield };


        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long ShirtNumber { get; set; }

        [JsonProperty("position")]
        public PositionE Position { get; set; }

        public override string ToString() => $"{Name} ( {ShirtNumber} )";

        internal string ParseForFileLine() => $"{Name}{DEL}{Captain}{DEL}{ShirtNumber}{DEL}{Position}{DEL}";
    }
}
