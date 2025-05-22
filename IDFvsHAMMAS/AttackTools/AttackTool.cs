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

    

    
    

   

   
    
    
}