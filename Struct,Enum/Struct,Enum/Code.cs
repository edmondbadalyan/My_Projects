using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Enum
{
    public enum Race
    {
        Orc,
        Elf,
        Human,
        Gnome,
        Troll,
        Goblin
    }

    public enum Role
    {
        Warrior,
        Mage,
        Priest,
        Rogue,
        Hunter,
        Druid
    }

    public struct HealthBar
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }

        public HealthBar(int currentHealth, int maxHealth)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
        }

        public override string ToString()
        {
            return $"{CurrentHealth} / {MaxHealth}";
        }
    }

    public class Character
    {
        public Race CharacterRace { get; }
        public Role CharacterRole { get; }
        public int BaseAttack { get; set; }
        public int BaseHealth { get; set; }
        public HealthBar Health { get; set; }

        public Character(Race race, Role role)
        {
            CharacterRace = race;
            CharacterRole = role;

            BaseAttack = 10;
            BaseHealth = 100;

            AdjustStatsByRace();
            AdjustStatsByRole();

            Health = new HealthBar(BaseHealth, BaseHealth);
        }

        private void AdjustStatsByRace()
        {
            switch (CharacterRace)
            {
                case Race.Orc:
                    BaseHealth += 20;
                    BaseAttack -= 5;
                    break;
                case Race.Elf:
                    BaseHealth -= 10;
                    BaseAttack += 76;
                    break;
                case Race.Human:
                    BaseHealth += 43;
                    BaseAttack -= 1;
                    break;
                case Race.Goblin:
                    BaseHealth += 34;
                    BaseAttack += 10;
                    break;
                case Race.Gnome:
                    BaseHealth += 10;
                    BaseAttack += 230;
                    break;
                case Race.Troll:
                    BaseHealth += 90;
                    BaseAttack += 14;
                    break;

            }
        }

        private void AdjustStatsByRole()
        {
            switch (CharacterRole)
            {
                case Role.Warrior:
                    BaseHealth += 60;
                    BaseAttack -= 5;
                    break;
                case Role.Mage:
                    BaseHealth -= 30;
                    BaseAttack += 20;
                    break;
                case Role.Druid:
                    BaseHealth += 100;
                    BaseAttack -= 0;
                    break;
                case Role.Priest:
                    BaseHealth += 3;
                    BaseAttack -= 1;
                    break;
                case Role.Hunter:
                    BaseHealth += 33;
                    BaseAttack -= 2;
                    break;
                case Role.Rogue:
                    BaseHealth += 1;
                    BaseAttack -= 2;
                    break;
            }
        }


        public override string ToString()
        {
            return $"Вы {CharacterRace}-{CharacterRole} 1 уровня:\nУ вас {BaseAttack} атаки и {Health} здоровья.";
        }
    }




}
