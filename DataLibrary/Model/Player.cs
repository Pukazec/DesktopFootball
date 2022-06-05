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
        public enum PositionE { Defender, Forward, Goalie, Midfield };


        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("captain")]
        public bool Captain { get; set; }

        [JsonProperty("shirt_number")]
        public long ShirtNumber { get; set; }

        [JsonProperty("position")]
        public PositionE Position { get; set; }
        //public enum PositionE
        //{ 
        //    Goalie,
        //    Defender,
        //    Forward,
        //    Midfield
        //}

        //public string Name { get; set; }
        //public bool Captain { get; set; }
        //public int ShirtNumber { get; set; }
        //public PositionE Position { get; set; }
    }
}
