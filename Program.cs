using System;
using System.Collections.Generic;

namespace Lab5_1_RPG
{

    class GameCharacter
    {
        protected string Name;
        protected int Strength;
        protected int Intelligence;



        // Constructor
        public GameCharacter(string _Name, int _Strength, int _Intelligence)
        {
            //Name = _Name;
            //Strength = _Strength;
            //Strength = _Strength;

            SetName(_Name);
            SetStrength(_Strength);
            SetIntelligence(_Intelligence);
        }





        // Getters and Setters for Name
        public string GetName()
        {
            return Name;
        }
        public void SetName(string _Name)
        {
            Name = _Name;
        }

        // Getters and Setters for Strength
        public int GetStrength()
        {
            return Strength;
        }
        public void SetStrength(int _Strength)
        {
            Strength = _Strength;
        }

        // Getters and Setters for Strength
        public int GetIntelligence()
        {
            return Intelligence;
        }
        public void SetIntelligence(int _Intelligence)
        {
            Intelligence = _Intelligence;
        }


        public virtual void Play()
        {
            Console.WriteLine($"{Name} , {Strength}, {Intelligence}");
        }

    }


    class Warrior : GameCharacter
    {
        public string weaponType;

        public Warrior(string _Name, int _Strength, int _Intelligence, string _weaponType) : base(_Name, _Strength, _Intelligence)
        {
            weaponType = _weaponType;
        }

        public override void Play()
        {
            Console.WriteLine($"\nWarrior Name: {Name} \nStrength: {Strength}, \nIntelligence: {Intelligence} \nWeapon Type: {weaponType}");
        }
    }

    class MagicUsingCharacter : GameCharacter
    {
        public int magicalEnergy;

        public MagicUsingCharacter(string _Name, int _Strength, int _Intelligence, int _magicalEnergy) : base(_Name, _Strength, _Intelligence)
        {
            magicalEnergy = _magicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($"Name: {Name} \nStrength: {Strength}, \nIntelligence: {Intelligence} \nMagical Energy: {magicalEnergy}");
        }
    }

    class Wizard : MagicUsingCharacter
    {
        public int spellNumber;

        public Wizard(string _Name, int _Strength, int _Intelligence, int _magicalEnergy, int _spellNumber) : base(_Name, _Strength, _Intelligence, _magicalEnergy)
        {
            spellNumber = _spellNumber;
        }
        public override void Play()
        {
            Console.WriteLine($"\nWizard Name: {Name} \nStrength: {Strength}, \nIntelligence: {Intelligence} \nMagical Energy: {magicalEnergy} \nSpell Number: {spellNumber}");
        }
    }





    class Program
    {

        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            // Add Warriors
            Warrior war1 = new Warrior("Winston", 87, 100, "Teeth");
            gameCharacters.Add(war1);

            war1 = new Warrior("Jacob the Conqueror", 98, 78, "Axe");
            gameCharacters.Add(war1);

            // Add Wizards
            Wizard wiz1 = new Wizard("Spinelli", 54, 100, 32, 8);
            gameCharacters.Add(wiz1);

            wiz1 = new Wizard("Ri'Chard", 29, 58, 61, 29);
            gameCharacters.Add(wiz1);

            wiz1 = new Wizard("Timothy", 48, 33, 79, 42);
            gameCharacters.Add(wiz1);

            foreach (GameCharacter mycharacter in gameCharacters)
            {
                mycharacter.Play();
            }

        }
    }
}

