﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    public class TeamStatistics
    {
        public enum TacticsE
        {
            [EnumMember(Value = "3-4-2-1")]
            The3421, 
            [EnumMember(Value = "3-4-3")]
            The343, 
            [EnumMember(Value = "3-5-2")]
            The352, 
            [EnumMember(Value = "4-2-3-1")]
            The4231, 
            [EnumMember(Value = "4-3-2-1")]
            The4321, 
            [EnumMember(Value = "4-3-3")]
            The433, 
            [EnumMember(Value = "4-4-2")]
            The442, 
            [EnumMember(Value = "4-5-1")]
            The451, 
            [EnumMember(Value = "5-3-2")]
            The532, 
            [EnumMember(Value = "5-4-1")]
            The541 
        };


        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("attempts_on_goal")]
        public long AttemptsOnGoal { get; set; }

        [JsonProperty("on_target")]
        public long OnTarget { get; set; }

        [JsonProperty("off_target")]
        public long OffTarget { get; set; }

        [JsonProperty("blocked")]
        public long Blocked { get; set; }

        [JsonProperty("woodwork")]
        public long Woodwork { get; set; }

        [JsonProperty("corners")]
        public long Corners { get; set; }

        [JsonProperty("offsides")]
        public long Offsides { get; set; }

        [JsonProperty("ball_possession")]
        public long BallPossession { get; set; }

        [JsonProperty("pass_accuracy")]
        public long PassAccuracy { get; set; }

        [JsonProperty("num_passes")]
        public long NumPasses { get; set; }

        [JsonProperty("passes_completed")]
        public long PassesCompleted { get; set; }

        [JsonProperty("distance_covered")]
        public long DistanceCovered { get; set; }

        [JsonProperty("balls_recovered")]
        public long BallsRecovered { get; set; }

        [JsonProperty("tackles")]
        public long Tackles { get; set; }

        [JsonProperty("clearances")]
        public long Clearances { get; set; }

        [JsonProperty("yellow_cards")]
        public long YellowCards { get; set; }

        [JsonProperty("red_cards")]
        public long RedCards { get; set; }

        [JsonProperty("fouls_committed")]
        public long? FoulsCommitted { get; set; }

        [JsonProperty("tactics")]
        public TacticsE Tactics { get; set; }

        [JsonProperty("starting_eleven")]
        public List<Player> StartingEleven { get; set; }

        [JsonProperty("substitutes")]
        public List<Player> Substitutes { get; set; }
        //public Team Team { get; set; }
        //public int AttemptsOnGoal { get; set; }
        //public int OnTarget { get; set; }
        //public int OffTarget { get; set; }
        //public int Blocked { get; set; }
        //public int Woodwork { get; set; }
        //public int Corners { get; set; }
        //public int Offsides { get; set; }
        //public int BallPossession { get; set; }
        //public int PassAccuracy { get; set; }
        //public int NumPasses { get; set; }
        //public int PassesCompleted { get; set; }
        //public int DistanceCovered { get; set; }
        //public int BallsRecovered { get; set; }
        //public int Tackles { get; set; }
        //public int Clearances { get; set; }
        //public int YellowCards { get; set; }
        //public int RedCards { get; set; }
        //public int FoulsCommitted { get; set; }
        //public string Tactics { get; set; }
    }
}
