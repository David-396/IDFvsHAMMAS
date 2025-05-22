using System.Security.Cryptography;

namespace IDFvsHAMMAS
{
    public abstract class AttackTool
    {
        protected string Name;
        protected int ID;
        protected string DamageType;
        protected string EffectiveAgaints;
        protected int? Ammo;
        
        public AttackTool(string name, int id, string damageType, string effectiveAgaints, int ammo = 100)
        {
            this.Name = name;
            this.ID = id;
            this.DamageType = damageType;
            this.EffectiveAgaints = effectiveAgaints;
            this.Ammo  = ammo;
        }
        
        public string GetName()
        {
            return this.Name;
        }
        
        public int GetID()
        {
            return this.ID;
        }
        public string GetDamageType()
        {
            return this.DamageType;
        }
        public string GetEffectiveAgaints()
        {
            return this.EffectiveAgaints;
        }
        public int? GetAmmo()
        {
            return this.Ammo;
        }

    }

    public abstract class MeleeWeapon : AttackTool
    {
        public MeleeWeapon(string name, int id, string damageType, string effectiveAgaints) : base(name, id, damageType, effectiveAgaints){}
    }

    public abstract class FirawarmWeapon : AttackTool
    {
        public FirawarmWeapon(string name, int id, string damageType, string effectiveAgaints) : base(name, id, damageType, effectiveAgaints){}
    }

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

    public abstract class AirCraft : CombatVehicle
    {
        public AirCraft(string name, int id, string damageType, string effectiveAgaints, int fuel, int crew, int ammo) : base(name, id, damageType, effectiveAgaints, fuel, crew, ammo){}
    }

    public abstract class GroundVehicle : CombatVehicle
    {
        public GroundVehicle(string name, int id, string damageType, string effectiveAgaints, int fuel, int crew, int ammo) : base(name, id, damageType, effectiveAgaints, fuel, crew, ammo){}
    }
    
    public abstract class SeaVehicle : CombatVehicle
    {
        public SeaVehicle(string name, int id, string damageType, string effectiveAgaints, int fuel, int crew, int ammo) : base(name, id, damageType, effectiveAgaints, fuel, crew, ammo){}
    }
}