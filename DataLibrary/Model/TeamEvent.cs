using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    public class TeamEvent
    {
        public enum TypeOfEventE { Goal, GoalOwn, GoalPenalty, RedCard, SubstitutionIn, SubstitutionOut, YellowCard, YellowCardSecond };

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("type_of_event")]
        public TypeOfEventE TypeOfEvent { get; set; }

        [JsonProperty("player")]
        public string Player { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
        //public int Id { get; set; }
        //public string TypeOfEvent { get; set; }
        //public Player Player { get; set; }
        //public string Time { get; set; }
    }
}
