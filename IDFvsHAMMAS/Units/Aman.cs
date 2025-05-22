using System.Collections.Generic;
using IDFvsHAMMAS.AbstractClasses.Person;

namespace IDFvsHAMMAS.Unit
{
    internal class Aman : Unit
    {
        private string intelMessage;
        private List<Terrorist> ListOfTerrorists;
        private Dictionary<Terrorist, string> TerroristLocation;
        private Dictionary<string, double> TimeOfIntel;

        public Aman(string name, int id, string type, string commander, int missionId, List<Soldier> soldiers,
            List<AttackTool> strike, string intelMessage, List<Terrorist> ListOfTerrorists,
            Dictionary<Terrorist, string> TerroristLocation, Dictionary<string, double> TimeOfIntel) : base(name, id,
            type, commander, missionId, soldiers, strike)
        {
            this.intelMessage = intelMessage;
            this.ListOfTerrorists = ListOfTerrorists;
            this.TerroristLocation = TerroristLocation;
            this.TimeOfIntel = TimeOfIntel;
        }
        
        public string GetIntelMessage()
        {
            return this.intelMessage;
        }
        
        public List<Terrorist> GetListOfTerrorists()
        {
            return this.ListOfTerrorists;
        }
        
        public Dictionary<Terrorist, string> GetTerroristLocation()
        {
            return this.TerroristLocation;
        }
        
        public Dictionary<string, double> GetTimeOfIntel()
        {
            return this.TimeOfIntel;
        }
    }
}