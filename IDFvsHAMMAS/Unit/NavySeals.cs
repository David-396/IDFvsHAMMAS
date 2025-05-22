namespace IDFvsHAMMAS
{
    internal class NavySeals : Unit
    {
        public NavySeals(string name, int id, string type, string commander, int missionID, List<Soldires> soldires, List<AttackTool> strike): base(name, id, type, commander, missionID, soldires, strike){}
    }
}