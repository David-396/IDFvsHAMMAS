namespace IDFvsHAMMAS
{
    public abstract class CombatVehicle : AttackTool
    {
        protected int Fuel;
        protected int Crew;
        protected int Ammo;

        public CombatVehicle(string name, int id, string damageType, string effectiveAgaints, int fuel, int crew,
            int ammo) : base(name, id, damageType, effectiveAgaints)
        {
            this.Fuel = fuel;
            this.Crew = crew;
            
            
        }
        
        public int GetFuel()
        {
            return this.Fuel;
        }
        
        public int GetCrew()
        {
            return this.Crew;
        }
        
    }
}