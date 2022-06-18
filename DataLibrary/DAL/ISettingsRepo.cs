using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DAL
{
    public interface ISettingsRepo
    {
        Settings LoadSettings();
        void SaveMainSettings();
        void SaveRepresentation();
        void SavePlayers();
    }
}
