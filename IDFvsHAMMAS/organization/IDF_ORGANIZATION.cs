using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFvsHAMMAS.AbstractClasses.Person;
using IDFvsHAMMAS.AbstractClasses;
using IDFvsHAMMAS.Unit;


namespace IDFvsHAMMAS.IDF
{
    internal abstract class IDF_ORGANIZATION : Organization
    {
        protected int HumanResource;
        protected List<Unit.Unit> UnitsLST;

        public IDF_ORGANIZATION(string Establishment, Soldier Commander, List<Soldier> SoldiersLst)
            : base(Establishment, Commander, SoldiersLst)
        {
            this.HumanResource = this.SoldiersLst.Count();
        }

        public int GetHumanResource()
        {
            return this.HumanResource;
        }
        public List<Unit.Unit> GetUnitsLST()
        {
            return this.UnitsLST;
        }

        public bool AddUnit(Unit.Unit unit)
        {
            if (this.UnitsLST.Contains(unit))
            {
                Console.WriteLine($"the unit {unit} is already in the list");
                return false;
            }
            Console.WriteLine($"{unit} added to the list");
            return true;
        }

        
    }
}