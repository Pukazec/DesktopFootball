﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    public class Match
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverterWithAttributeSupport))]
        public enum StageNameE 
        {
            Final,
            [EnumMember(Value = "Final Stage")]
            FirstStage, 
            [EnumMember(Value = "Play Off For Third Place")]
            PlayOffForThirdPlace, 
            [EnumMember(Value = "Quarter Finals")]
            QuarterFinals, 
            [EnumMember(Value = "Round Of 16")]
            RoundOf16, 
            [EnumMember(Value = "Semi Finals")]
            SemiFinals 
        };


        [JsonProperty("venue")]
        public string Venue { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("fifa_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(ParseStringConverter))]
        public long FifaId { get; set; }

        [JsonProperty("weather")]
        public Weather Weather { get; set; }

        [JsonProperty("attendance")]
        [System.Text.Json.Serialization.JsonConverter(typeof(ParseStringConverter))]
        public long Attendance { get; set; }

        [JsonProperty("officials")]
        public List<string> Officials { get; set; }

        [JsonProperty("stage_name")]
        public StageNameE StageName { get; set; }

        [JsonProperty("home_team_country")]
        public string HomeTeamCountry { get; set; }

        [JsonProperty("away_team_country")]
        public string AwayTeamCountry { get; set; }

        [JsonProperty("datetime")]
        public DateTimeOffset Datetime { get; set; }

        [JsonProperty("winner")]
        public string Winner { get; set; }

        [JsonProperty("winner_code")]
        public string WinnerCode { get; set; }

        [JsonProperty("home_team")]
        public Team HomeTeam { get; set; }

        [JsonProperty("away_team")]
        public Team AwayTeam { get; set; }

        [JsonProperty("home_team_events")]
        public List<TeamEvent> HomeTeamEvents { get; set; }

        [JsonProperty("away_team_events")]
        public List<TeamEvent> AwayTeamEvents { get; set; }

        [JsonProperty("home_team_statistics")]
        public TeamStatistics HomeTeamStatistics { get; set; }

        [JsonProperty("away_team_statistics")]
        public TeamStatistics AwayTeamStatistics { get; set; }

        [JsonProperty("last_event_update_at")]
        public DateTimeOffset LastEventUpdateAt { get; set; }

        [JsonProperty("last_score_update_at")]
        public DateTimeOffset? LastScoreUpdateAt { get; set; }
        //public MatchLocation Location { get; set; }
        //public string Status { get; set; }
        //public string Time { get; set; }
        //public long FifaId { get; set; }
        //public Weather Weather { get; set; }
        //public int Attendance { get; set; }
        //public IList<String> Officials { get; set; }
        //public string StageName { get; set; }
        //public Team HomeTeamCountry { get; set; }
        //public Team AwayTeamCountry { get; set; }
        //public DateTime DateTime { get; set; }
        //public Team Winner { get; set; }
        //public TeamEvents HomeTeamEvents { get; set; }
        //public TeamEvents AwayTeamEvents { get; set; }
        //public TeamStatistics HomeTeamStatistics { get; set; }
        //public TeamStatistics AwayTeamStatistics { get; set; }
        //public IList<Player> StartingEleven { get; set; }
        //public IList<Player> Substitutes { get; set; }
        //public DateTime LastEventUpdate { get; set; }
        //public DateTime LastScoreUpdate { get; set; }
    }
}