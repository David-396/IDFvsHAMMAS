using System.Collections.Generic;

namespace IDFvsHAMMAS
{
    internal class Aman : Unit
    {
        private string intelMessege;
        private List<Terrorist> ListOfTerrorists;
        private Dictionary<Terroris, string> TeroristLocation;
        private Dictionary<string, double> TimeOfIntel;

        public Aman(string name, int id, string type, string commander, int missionID, List<Soldier> soldiers,
            List<AttackTool> strike, string intelMessege, List<Terrorist> ListOfTerrorists,
            Dictionary<Terrorist, string> TeroristLocation, Dictionary<string, double> TimeOfIntel) : base(name, id,
            type, commander, missionID, soldiers, strike)
        {
            this.intelMessege = intelMessege;
            this.ListOfTerrorists = ListOfTerrorists;
            this.TeroristLocation = TeroristLocation;
            this.TimeOfIntel = TimeOfIntel;
        }
        
        public string GetIntelMessege()
        {
            return this.intelMessege;
        }
        
        public List<Terrorist> GetListOfTerrorists()
        {
            return this.ListOfTerrorists;
        }
        
        public Dictionary<Terroris, string> GetTeroristLocation()
        {
            return this.TeroristLocation;
        }
        
        public Dictionary<string, double> GetTimeOfIntel()
        {
            return this.TimeOfIntel;
        }
    }
}