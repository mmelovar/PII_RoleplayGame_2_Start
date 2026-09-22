//--------------------------------------------------------------------------------
// <copyright file="SpellsBook.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Library.Items.AttackDefenseItem
{
    /// <summary>
    /// Representa un libro de hechizos. Su ataque y su defensa son la suma de
    /// los hechizos que contiene.
    /// </summary>
    public class SpellsBook : AttackDefenseItem
    {
        private readonly List<Spell> spells = new List<Spell>();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="SpellsBook"/>.
        /// </summary>
        /// <param name="name">El nombre del libro.</param>
        public SpellsBook(string name)
            : base(name, 0, 0, true)
        {
        }

        public List<Spell> Spells => spells;


        /// <summary>
        /// Obtiene los hechizos del libro. Es de solo lectura: para modificarla
        /// se usan <see cref="AddSpell"/> y <see cref="RemoveSpell"/>.
        /// </summary>

        /// <inheritdoc/>
        public void AddSpell(Spell spell)
        {
            ArgumentNullException.ThrowIfNull(spell);

            spells.Add(spell);
            AttackValue += spell.AttackValue;
            DefenseValue += spell.DefenseValue;
        }

        /// <inheritdoc/>
        public void RemoveSpell(Spell spell)
        {
            ArgumentNullException.ThrowIfNull(spell);

            if (spells.Remove(spell))
            {
                AttackValue -= spell.AttackValue;
                DefenseValue -= spell.DefenseValue;
            }
        }
    }
}
