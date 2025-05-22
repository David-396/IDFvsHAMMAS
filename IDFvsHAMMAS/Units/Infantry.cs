using System.Collections.Generic;
using IDFvsHAMMAS.AbstractClasses.Person;

namespace IDFvsHAMMAS.Unit
{
    internal class Infantry : Unit
    {
        public Infantry(string name, int id, string type, string commander, int missionId, List<Soldier> soldiers, List<AttackTool> strike): base(name, id, type, commander, missionId, soldiers, strike){}
    }
}