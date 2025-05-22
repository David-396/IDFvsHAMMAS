using IDFvsHAMMAS.AbstractClasses;
using System.Collections.Generic;
using IDFvsHAMMAS.AbstractClasses.Person;

namespace IDFvsHAMMAS.Unit
{
    public abstract class Unit
    {
        protected string Name;
        protected int ID;
        protected string Type;
        protected string Commander;
        protected int MissionID;
        protected List<Soldier> Soldiers;
        protected List<AttackTool> Strike;
       
        public Unit(string name, int id, string type, string commander, int missionID, List<Soldier> soldiers, List<AttackTool> strike)
        {
            this.Name = name;
            this.ID = id;
            this.Type = type;
            this.Commander = commander;
            this.MissionID = missionID;
            this.Soldiers = soldiers;
            this.Strike = strike;
        }

        public string GetName()
        {
            return this.Name;
        }
       
        public int GetID()
        {
            return this.ID;
        }
       
        public string GetType()
        {
            return this.Type;
        }
       
        public string GetCommander()
        {
            return this.Commander;
        }
       
        public int GetMissionID()
        {
            return this.MissionID;
        }
    }
}