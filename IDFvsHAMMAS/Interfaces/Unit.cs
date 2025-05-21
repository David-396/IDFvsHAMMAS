namespace IDFvsHAMMAS.Interfaces
{
    abstract class Unit
    {
        protected string Commander;
        protected int ID;
        protected string Name;
        protected string Type;
        protected int MissionID;

        public Unit(string commander, int id, string name, string type, int missionID)
        {
            this.Commander = commander;
            this.ID = id;
            this.Name = name;
            this.Type = type;
            this.MissionID = missionID;
        }

        public string GetCommander()
        {
            return this.Commander;
        }

        public int GetID()
        {
            return this.ID;
        }
        
        public string GetName()
        {
            return this.Name;
        }
        
        public string GetType()
        {
            return this.Type;
        }
        
        public int GetMissionID()
        {
            return this.MissionID;
        }
       
    }
}