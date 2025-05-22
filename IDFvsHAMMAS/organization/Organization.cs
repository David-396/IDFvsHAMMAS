using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFvsHAMMAS.AbstractClasses.Person;

namespace IDFvsHAMMAS.AbstractClasses
{
    public abstract class Organization
    {
        protected string Establishment;
        protected Soldier Commander;
        protected List<Soldier> SoldiersLst;

        public Organization(string Establishment, Soldier Commander, List<Soldier> SoldiersLst)
        {
            this.Establishment = Establishment;
            this.Commander = Commander;
            this.SoldiersLst = SoldiersLst;
        }

        public string GetEstablishment()
        {
            return this.Establishment;
        }
        public Soldier GetCommander()
        {
            return this.Commander;
        }
        public List<Soldier> GetSoldiersLst()
        {
            return this.SoldiersLst;
        }

        public bool AddSoldier(Soldier soldier)
        {
            if (this.SoldiersLst.Contains(soldier))
            {
                return false;
            }
            this.SoldiersLst.Add(soldier);
            return true;

        } 

        public bool RemoveSoldier(Soldier soldier)
        {
            if (this.SoldiersLst.Contains(soldier))
            {
                this.SoldiersLst.Remove(soldier);
                return true;
            }
            return false;
            
        }
    }
}
