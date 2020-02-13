using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public string Name { get; set; }
        public int Count => this.gladiators.Count ;
        public Arena(string name)
        {
            this.gladiators = new List<Gladiator>();
            this.Name = name;
        }

       
        //•	Method GetGladitorWithHighestStatPower() – returns the Gladiator which has the highest stat.
        //•	Method GetGladitorWithHighestWeaponPower() – returns the Gladiator which poses the weapon with the highest power.
        //•	Method GetGladitorWithHighestTotalPower() – returns the Gladiator which has the highest total power.

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            Gladiator targetName = this.gladiators.FirstOrDefault(x => x.Name == name);
            gladiators.Remove(targetName);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            Gladiator gladiator = this.gladiators.OrderByDescending(x => x.GetStatPower()).FirstOrDefault();
            return gladiator;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            Gladiator gladiator = this.gladiators.OrderByDescending(x => x.Gettotalpower()).FirstOrDefault();
            return gladiator;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            Gladiator highest = this.gladiators.OrderByDescending(x => x.Gettotalpower()).FirstOrDefault();
            return highest;
        }

        public override string ToString()
        {
            return $"[{this.Name}] - [{this.Count}] gladiators are participating.";
        }


    }
}
