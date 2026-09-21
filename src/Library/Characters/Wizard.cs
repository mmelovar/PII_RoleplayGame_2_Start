//--------------------------------------------------------------------------------
// <copyright file="Wizard.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Library.Items;

namespace Library.Characters
{
    /// <summary>
    /// Representa un personaje Mago (Wizard).
    /// Puede equipar un báculo (Staff) y un libro de hechizos (SpellsBook).
    /// </summary>
    public class Wizard : Character
    {
        public Wizard(string name, int health, int baseAttack, int baseDefense)
            : base(name, health, baseAttack, baseDefense)
        {
        }

        public Staff Staff { get; protected set; }

        public SpellsBook SpellsBook { get; protected set; }

        public override int GetAttackValue()
        {
            int total = BaseAttack;

            if (Staff != null)
            {
                total += Staff.AttackValue;
            }

            if (SpellsBook != null)
            {
                total += SpellsBook.AttackValue;
            }

            return total;
        }

        public override int GetDefenseValue()
        {
            int total = BaseDefense;

            if (Staff != null)
            {
                total += Staff.DefenseValue;
            }

            if (SpellsBook != null)
            {
                total += SpellsBook.DefenseValue;
            }

            return total;
        }

        public void SetItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            Staff staff = item as Staff;
            if (staff != null)
            {
                Staff = staff;
                return;
            }

            SpellsBook spellsBook = item as SpellsBook;
            if (spellsBook != null)
            {
                SpellsBook = spellsBook;
                return;
            }

            throw new ArgumentException("El mago solo puede equipar un 'Staff' o un 'SpellsBook'.", nameof(item));
        }

        public void GetItem(Item item)
        {
            SetItem(item);
        }

        public void DropItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (item is Staff)
            {
                Staff = null;
                return;
            }

            if (item is SpellsBook)
            {
                SpellsBook = null;
                return;
            }

            throw new ArgumentException("El mago solo puede desequipar un 'Staff' o un 'SpellsBook'.", nameof(item));
        }
    }
}
