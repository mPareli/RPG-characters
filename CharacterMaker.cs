using System.Diagnostics;
using RPG_Characters.Characters;

namespace RPG_Characters;

public static class CharacterMaker
{
    public static Character RandomCharacter()
    {
        Console.WriteLine("Creating a new random character");
        Random random = new Random();
        
        // Create a random name
        String name = "Bobbington";


        List<String> start = new List<string>();
        start.Add("Gan");
        start.Add("Ara");
        start.Add("Gim");
        start.Add("Fro");

        List<String> end = new List<string>();
        start.Add("dalf");
        start.Add("gorn");
        start.Add("li");
        start.Add("do");
        
        // Create random name 
        String name = start[random.Next(start.Count)] + end[random.Next(end.Count)];
        
        // Add character and weapon options
        List<String> characterOptions = new List<string>();
        characterOptions.Add(item:"Fighter");
        characterOptions.Add(item:"Wizard");
        characterOptions.Add(item:"Ranger");
        characterOptions.Add(item:"Rogue");
        characterOptions.Add(item:"Bard");

        List<String> weaponOptions = new List<string>();
        weaponOptions.Add("Bow");
        weaponOptions.Add("Staff");
        weaponOptions.Add("Sword");
        
        // Initialize a base character
        Character character = null;
        
        
        // pick a random class
        int roll = random.Next(characterOptions.Count);
        
        //Console.WriteLine($"Rolled a {roll}: {characterOptions}");
        switch (characterOptions[roll])
        {
            case "Fighter":
                character = new Fighter(name);
                break;
            case "Ranger":
                character = new Ranger(name);
                break;
            case "Rogue":
                character = new Rogue(name);
                break;
            case "Wizard":
                character = new Wizard(name);
                break;
            case "Bard":
                character = new Bard(name);
        }
        
        
        // pick a random weapon
        roll = random.Next(weaponOptions.Count);
        Switch (weaponOptions[roll])
        {
            case "Bow":
                weapon = 
            
        }
        
        return character
    }
}