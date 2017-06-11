using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XunitDemo
{
    public class PlayerCharacter
    {
        public PlayerCharacter()
        {
            Name = GenerateName();

            IsNoob = true;

            CreateStartingWeapons();
        }

        public int Health { get; set; }

        public string Name { get; set; }

        public string NickName { get; set; }

        public bool IsNoob { get; set; }

        public List<string> Weapons { get; set; }

        private string GenerateName()
        {
            var names = new[]
            {
                "Muna",
                "Emon",
                "Rahul",
                "Minhaj",
                "Jahin",
                "Monjur"
            };

            return names[new Random().Next(0, names.Length)];
        }

        private void CreateStartingWeapons()
        {
            this.Weapons = new List<string>()
            {
                "Long Bow",
                "Short Bow",
                "Long Sword",
                "Sword"
            };
        }

        public void Sleep()
        {
            var rnd = new Random();

            var healthIncrease = rnd.Next(1, 101);

            Health += healthIncrease;
        }
    }
}
