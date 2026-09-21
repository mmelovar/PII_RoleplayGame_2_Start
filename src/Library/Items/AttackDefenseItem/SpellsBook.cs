//--------------------------------------------------------------------------------
// <copyright file="SpellsBook.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Library.Items
{
    /// <summary>
    /// Representa un libro de hechizos que almacena una lista de hechizos.
    /// </summary>
    public class SpellsBook : Item
    {
        private readonly List<Spell> spells = new List<Spell>();

        public SpellsBook(string name)
            : base(name, 0, 0)
        {
        }

        public List<Spell> Spells => spells;

        public void AddSpell(Spell spell)
        {
            if (spell == null)
            {
                throw new ArgumentNullException(nameof(spell));
            }

            spells.Add(spell);
            AttackValue += spell.AttackValue;
            DefenseValue += spell.DefenseValue;
        }

        public void RemoveSpell(Spell spell)
        {
            if (spell == null)
            {
                throw new ArgumentNullException(nameof(spell));
            }

            if (spells.Remove(spell))
            {
                AttackValue -= spell.AttackValue;
                DefenseValue -= spell.DefenseValue;
            }
        }
    }
}
