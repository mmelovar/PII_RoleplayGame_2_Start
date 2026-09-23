//--------------------------------------------------------------------------------
// <copyright file="Elf.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Library.Items;
using Library.Items.AttackDefenseItem;
using Library.Items.AttackItem;
using Library.Items.DefenseItem;

namespace Library.Characters
{
    /// <summary>
    /// Representa un personaje de tipo Elfo (Elf).
    /// </summary>
    public class Elf : Character
    {    
        /// <summary>
        /// Obtiene o establece la espada del elfo.
        /// </summary>
        public Sword Sword { get; protected set; }

        /// <summary>
        /// Obtiene o establece el arco del elfo.
        /// </summary>
     
        public Bow Bow { get; protected set; }

        /// <summary>
        /// Obtiene o establece la armadura del elfo.
        /// </summary>
        public Armor Armor { get; protected set; }

        /// <summary>
        /// Obtiene o establece el casco del elfo.
        /// </summary>
        public Helmet Helmet { get; protected set; }

    /// <summary>
    /// Inicializa una nueva instancia de la clase <see cref="Elf"/>.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="health"></param>
    /// <param name="baseAttack"></param>
    /// <param name="baseDefense"></param>
    public Elf(string name, int health, int baseAttack, int baseDefense)
        : base(name, health, baseAttack, baseDefense)
    {
    }

    /// <summary>
    /// Obtiene el valor total de ataque del elfo, incluyendo su ataque base y los valores de ataque de los elementos equipados.
    /// </summary>
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

    /// <summary>
    /// Obtiene el valor total de defensa del elfo, incluyendo su defensa base y los valores de defensa de los elementos equipados.
    /// </summary>
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

    /// <summary>
    /// Establece una espada para el elfo.
    /// </summary>
    /// <param name="sword"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public void EquipSword(Sword sword)
    {
        if (sword == null)
        {
            throw new ArgumentNullException(nameof(sword), "La espada no puede ser nula.");
        }
        Sword = sword;
    }

    /// <summary>
    /// Establece un arco para el elfo.
    /// </summary>
    /// <param name="bow"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public void EquipBow(Bow bow)
    {
        if (bow == null)
        {
            throw new ArgumentNullException(nameof(bow), "El arco no puede ser nulo.");
        }
        Bow = bow;
    }
    /// <summary>
    /// Establece una armadura para el elfo.
    /// </summary>
    /// <param name="armor"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public void EquipArmor(Armor armor)
    {
        if (armor == null)
        {
            throw new ArgumentNullException(nameof(armor), "La armadura no puede ser nula.");
        }
        Armor = armor;
    }

    /// <summary>
    /// Establece un casco para el elfo.
    /// </summary>
    /// <param name="helmet"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public void EquipHelmet(Helmet helmet)
    {
        if (helmet == null)
        {
            throw new ArgumentNullException(nameof(helmet), "El casco no puede ser nulo.");
        }
        Helmet = helmet;
    }

    /// <summary>
    /// Libera la espada del elfo.
    /// </summary>
    public void UnequipSword()
    {
        Sword = null;
    }

    /// <summary>
    /// Libera el arco del elfo.
    /// </summary>
    public void UnequipBow()
    {
        Bow = null;
    }

    /// <summary>
    /// Libera la armadura del elfo.
    /// </summary>
    public void UnequipArmor()
    {
        Armor = null;
    }

    /// <summary>
    /// Libera el casco del elfo.
    /// </summary>
    public void UnequipHelmet()
    {
        Helmet = null;
    }
}
}