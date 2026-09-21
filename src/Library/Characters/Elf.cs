using System;
using Library.Items;

namespace Library.Characters
{
public class Elf : Character
{
    public Sword Sword { get; protected set; }
    public Bow Bow { get; protected set; }
    public Armor Armor { get; protected set; }
    public Helmet Helmet { get; protected set; }

    public Elf(string name, int health, int baseAttack, int baseDefense)
        : base(name, health, baseAttack, baseDefense)
    {
    }

    public override int GetAttackValue()
    {
        int total = BaseAttack;

        if (Sword != null)
        {
            total += Sword.AttackValue;
        }

        if (Bow != null)
        {
            total += Bow.AttackValue;
        }

        return total;
    }

    public override int GetDefenseValue()
    {
        int total = BaseDefense;

        if (Armor != null)
        {
            total += Armor.DefenseValue;
        }

        if (Helmet != null)
        {
            total += Helmet.DefenseValue;
        }

        return total;
    }
    public void EquipSword(Sword sword)
    {
        if (sword == null)
        {
            throw new ArgumentNullException(nameof(sword), "La espada no puede ser nula.");
        }
        Sword = sword;
    }
    public void EquipBow(Bow bow)
    {
        if (bow == null)
        {
            throw new ArgumentNullException(nameof(bow), "El arco no puede ser nulo.");
        }
        Bow = bow;
    }
    public void EquipArmor(Armor armor)
    {
        if (armor == null)
        {
            throw new ArgumentNullException(nameof(armor), "La armadura no puede ser nula.");
        }
        Armor = armor;
    }
    public void EquipHelmet(Helmet helmet)
    {
        if (helmet == null)
        {
            throw new ArgumentNullException(nameof(helmet), "El casco no puede ser nulo.");
        }
        Helmet = helmet;
    }
    public void UnequipSword()
    {
        Sword = null;
    }
    public void UnequipBow()
    {
        Bow = null;
    }
    public void UnequipArmor()
    {
        Armor = null;
    }
    public void UnequipHelmet()
    {
        Helmet = null;
    }
}
}