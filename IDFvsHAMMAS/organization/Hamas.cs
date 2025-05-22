using IDFvsHAMMAS.AbstractClasses;
using System.Collections.Generic;
using IDFvsHAMMAS.AbstractClasses.Person;
namespace IDFvsHAMMAS.organization
{
    public class Hamas : Organization
    {
        public Hamas(string Establishment, Soldier Commander, List<Soldier> SoldiersLst) : base(Establishment, Commander, SoldiersLst){}
    }
}