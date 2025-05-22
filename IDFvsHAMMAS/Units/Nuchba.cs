using System.Collections.Generic;
using IDFvsHAMMAS.AbstractClasses.Person;

namespace IDFvsHAMMAS.Unit
{
    public class Nuchba : Unit
    {
        public Nuchba(string name, int id, string type, string commander, int missionId, List<Soldier> soldiers, List<AttackTool> strike): base(name, id, type, commander, missionId, soldiers, strike){}
    }
}