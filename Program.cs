using RPG_Characters;
using RPG_Characters.Characters;
using RPG_Characters.Weapons;

class Program 
{
    static void Main(string[] args)
    {
        //Character char1 = new Character("Craig", "the ranger");
        //Weapon w1 = new Weapon("bow", "a fancy bow", WeaponAttackType.Ranged);
        //char1.EquipWeapon(w1);

        // create a character
        Character char1 = new Wizard("D9");
        // LSP means that we can choose any class to "fit" in
        
        // Create a weapon
        Weapon wep1 = new Staff();
        // LSP again
        
        // Tell the character to equip the weapon
        char1.EquipWeapon(wep1);
        
        // Attempt to attack
        Console.WriteLine(char1.Attack());
        
        
        
        

    }
}