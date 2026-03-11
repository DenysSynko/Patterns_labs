using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.creational.prototype
{
    internal class Warrior : Person
    {
        private string race;
        private string languages;
        private string type;
        private string weapon;

        public Warrior(string race, string lang, string type, string weapon) {
            this.race = race;
            this.languages = lang;
            this.type = type;
            this.weapon = weapon;
        }

        public override Person Clone(){
            return this;
        }

        public void Show()
        {
            Console.WriteLine($"race: {race}; languages: {languages}; type: {type}; weapon: {weapon}.");
        }
    }
}
