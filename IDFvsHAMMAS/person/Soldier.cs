using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDFvsHAMMAS.AbstractClasses.Person;

namespace IDFvsHAMMAS.AbstractClasses.Person
{
    public abstract class Soldier : Person
    {
        protected Unit.Unit Unit;
        protected string Role;
        protected int ID;
        protected AttackTool weapon;

        public Soldier(string name , int age, Unit.Unit unit, string role, int iD, AttackTool weapon) : base(name, age)
        {
            this.Unit = unit;
            this.Role = role;
            this.ID = iD;
            this.weapon = weapon;
        }

        public Unit.Unit GetUnit()
        {
            return this.Unit;
        }
        public string GetRole()
        {
            return this.Role;
        }
        public int GetID()
        {
            return this.ID;
        }
        public AttackTool GetWeapon()
        {
            return this.weapon;
        }


    }
}
