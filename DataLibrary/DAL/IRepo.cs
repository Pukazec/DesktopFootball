using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IRepo
    {
        IList<Match> LoadMatches();
        IList<Result> LoadResults();
        IList<GroupResults> LoadGroupResults();
        IList<Team> LoadTeams();
        void SaveSettings();
    }
}
