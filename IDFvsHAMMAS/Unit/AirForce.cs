namespace IDFvsHAMMAS
{
    internal class AirForce : Unit
    {
        public AirForce(string name, int id, string type, string commander, int missionID, List<Soldires> soldires, List<AttackTool> strike): base(name, id, type, commander, missionID, soldires, strike){}
    }
}