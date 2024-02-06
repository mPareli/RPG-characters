﻿namespace RPG_Characters;

public class Character
{
    private String _name; // The name of the actual character
    private String _className; 
    private String _description;
    private Weapon _equippedWeapon;

    protected List<WeaponAttackType> _allowedWeapons;
    // Collection: List
    

    public Character(string name, string className, string description)
    {
        _name = name;
        _className = className;
        _description = description;
        _allowedWeapons = new List<WeaponAttackType>();
    }

    public void EquipWeapon(Weapon weapon)
    {
        if (_allowedWeapons.Contains(weapon.AttackType))
        { 
            _equippedWeapon = weapon; 
        }
        else
        {
            // handle what happens when a character cant equip a weapon
        }
    }

    public String Attack()
    {
        //String message = $"The attack is a {AttackType} with a {_name}";
        if (_equippedWeapon == null)
        {
            return $"{_name} the {_className} can't attack without a weapon";
        }
        return $"{_name} the {_className} used a {_equippedWeapon.Attack()}";
    }
}