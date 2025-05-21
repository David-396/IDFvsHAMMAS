namespace IDFvsHAMMAS
{
    abstract class Unit
    {
       protected string Name;
       protected int ID;
       protected string Type;
       protected string Commander;
       protected int MissionID;
       
       public Unit(string name, int id, string type, string commander, int missionID)
       {
           this.Name = name;
           this.ID = id;
           this.Type = type;
           this.Commander = commander;
           this.MissionID = missionID;
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