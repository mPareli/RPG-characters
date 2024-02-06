namespace RPG_Characters.Characters;

public class Wizard: Character
{
    public Wizard(String name) : base(name, "Wizard", "a hocus pocus person")
    {
        _allowedWeapons.Add(WeaponAttackType.Magic);
    }
}