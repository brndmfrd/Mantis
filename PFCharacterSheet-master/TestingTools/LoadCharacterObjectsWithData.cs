using CharacterDataObjects;
using CharacterDataObjects.CharacterDataConstants;
using CharacterDataObjects.CharacterDataElements;

namespace TestingTools
{
    public class LoadCharacterObjectsWithData
    {
        public static bool IhaveBeenBuilt = false;

        public LoadCharacterObjectsWithData()
        {
            IhaveBeenBuilt = true;
        }

        //public void BuildUpNewCharacter()
        //{
        //    MyConnections.BasicCharacterInfo[Constants.CharacterName] = "Duraxis";
        //    MyConnections.BasicCharacterInfo[Constants.PlayerName] = "Bryan";
        //    MyConnections.BasicCharacterInfo[Constants.Alignment] = "True Neutral";
        //    MyConnections.BasicCharacterInfo[Constants.Size] = Constants.Medium;
        //    MyConnections.BasicCharacterInfo[Constants.Age] = "32";
        //    MyConnections.BasicCharacterInfo[Constants.Race] = "Human";
        //    MyConnections.BasicCharacterInfo[Constants.Deity] = "Pelor";
        //    MyConnections.BasicCharacterInfo[Constants.Gender] = "Male";
        //    MyConnections.BasicCharacterInfo[Constants.Height] = "6'4''";
        //    MyConnections.BasicCharacterInfo[Constants.Weight] = "260 lbs";
        //    MyConnections.BasicCharacterInfo[Constants.Eyes] = "Brown";
        //    MyConnections.BasicCharacterInfo[Constants.Hair] = "Brown";
        //    MyConnections.BasicCharacterInfo[Constants.Homeland] = "Muskegon";

        //    MyConnections.Languages.Add("Common");
        //    MyConnections.Languages.Add("Dwarven");
        //    MyConnections.Languages.Add("Elvish");


        //    MyConnections.AbilityScores[Constants.Strength] = new Ability
        //    {
        //        Name = Constants.Strength,
        //        Value = 17,
        //        TempAdjustment = 0,
        //        TempModifier = 0
        //    };
        //    MyConnections.AbilityScores[Constants.Dexterity] = new Ability
        //    {
        //        Name = Constants.Dexterity,
        //        Value = 13,
        //        TempAdjustment = 0,
        //        TempModifier = 0
        //    };
        //    MyConnections.AbilityScores[Constants.Constitution] = new Ability
        //    {
        //        Name = Constants.Constitution,
        //        Value = 16,
        //        TempAdjustment = 0,
        //        TempModifier = 0
        //    };
        //    MyConnections.AbilityScores[Constants.Intelligence] = new Ability
        //    {
        //        Name = Constants.Intelligence,
        //        Value = 11,
        //        TempAdjustment = 0,
        //        TempModifier = 0
        //    };
        //    MyConnections.AbilityScores[Constants.Wisdom] = new Ability
        //    {
        //        Name = Constants.Wisdom,
        //        Value = 16,
        //        TempAdjustment = 0,
        //        TempModifier = 0
        //    };
        //    MyConnections.AbilityScores[Constants.Charisma] = new Ability
        //    {
        //        Name = Constants.Charisma,
        //        Value = 13,
        //        TempAdjustment = 0,
        //        TempModifier = 0
        //    };


        //    MyConnections.Race.Name = "Dwarven";
        //    MyConnections.Size.Size = Constants.Medium;
        //    MyConnections.AC = new ArmorClass { Total = 25 };
        //    MyConnections.HP = new HitPoints { Total = 17 };
        //    MyConnections.Speed = new Movement { BaseSpeed = 5 };
            
        //    MyConnections.JobClasses.Add(
        //        "Demo Knight", new JobClass
        //        {
        //            Level = 12
        //        }
        //    );

        //    MyConnections.Weapons.Add(new Weapon(Constants.Strength, Constants.Strength) { WeaponName = "Bastard Sword" } );

        //    MyConnections.Armor.Add(new ArmorClassItems { ItemName = "Studded Leather", ArmorBonus = 4 });

        //    MyConnections.Skills.Add(Constants.Acrobatics, new Skill(Constants.Dexterity) { Name = Constants.Acrobatics, Ranks = 2 } );
        //    MyConnections.Skills.Add(Constants.Craft, new Skill(Constants.Intelligence) { Name = Constants.Craft, Ranks = 4 });
        //    MyConnections.Skills.Add(Constants.Swim, new Skill(Constants.Strength) { Name = Constants.Swim, Ranks = 2 });
        //    MyConnections.Skills.Add(Constants.HandleAnimal, new Skill(Constants.Wisdom) { Name = Constants.HandleAnimal, Ranks = 2 });

        //    MyConnections.Feats.Add(new Feat { Name = "Dodge" });
        //    MyConnections.Feats.Add(new Feat { Name = "Mobility" });
        //    MyConnections.Feats.Add(new Feat { Name = "Power Attack" });
        //    MyConnections.Feats.Add(new Feat { Name = "Weapon Focus" });

        //    MyConnections.Gear.Add(new Item { Name = "Flint and Steel" });
        //    MyConnections.Gear.Add(new Item { Name = "Torch" });
        //    MyConnections.Gear.Add(new Item { Name = "Bed roll" });
        //    MyConnections.Gear.Add(new Item { Name = "Backpack" });

        //    MyConnections.Money[Enums.Coins.CP] = 50;
        //    MyConnections.Money[Enums.Coins.SP] = 34;
        //    MyConnections.Money[Enums.Coins.GP] = 15;
        //    MyConnections.Money[Enums.Coins.PP] = 1;

        //    MyConnections.Spells.Add(new Spell { SpellName = "Prestidigitation" });
        //    MyConnections.Spells.Add(new Spell { SpellName = "Create Water" });
        //    MyConnections.Spells.Add(new Spell { SpellName = "Vampiric Touch" });
        //    MyConnections.Spells.Add(new Spell { SpellName = "Detect Magic" });

        //    MyConnections.SpellsPerDay[0] = 4;
        //    MyConnections.SpellsPerDay[1] = 3;
        //    MyConnections.SpellsPerDay[2] = 2;
        //    MyConnections.SpellsPerDay[3] = 1;

        //    MyConnections.SpellsKnown[0] = 4;
        //    MyConnections.SpellsKnown[1] = 3;
        //    MyConnections.SpellsKnown[2] = 2;
        //    MyConnections.SpellsKnown[3] = 1;




        //}


    }
}
