using System.Security.Cryptography;

namespace IDFvsHAMMAS
{
    public abstract class AttackTool
    {
        protected string Name;
        protected int ID;
        protected string DamageType;
        protected string EffectiveAgainst;
        protected int? Ammo;
        
        public AttackTool(string name, int id, string damageType, string effectiveAgainst, int ammo = 100)
        {
            this.Name = name;
            this.ID = id;
            this.DamageType = damageType;
            this.EffectiveAgainst = effectiveAgainst;
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
        public string GetEffectiveAgainst()
        {
            return this.EffectiveAgainst;
        }
        public int? GetAmmo()
        {
            return this.Ammo;
        }

    }

    

    
    

   

   
    
    
}