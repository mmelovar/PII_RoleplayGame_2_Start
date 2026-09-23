//--------------------------------------------------------------------------------
// <copyright file="SpellsBook.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library.Items.AttackDefenseItem
{
    /// <summary>
    /// Representa un libro de hechizos. Su ataque y su defensa son la suma de
    /// los hechizos que contiene.
    /// </summary>
    public class SpellsBook : AttackDefenseItem
    {
        private readonly List<Spell> spells = new List<Spell>();
        private readonly ReadOnlyCollection<Spell> readOnlySpells;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="SpellsBook"/>.
        /// </summary>
        /// <param name="name">El nombre del libro.</param>
        public SpellsBook(string name)
            : base(name, 0, 0, true)
        {
            readOnlySpells = spells.AsReadOnly();
        }

        /// <summary>
        /// Obtiene los hechizos del libro. Es de solo lectura: para modificarla
        /// se usan <see cref="AddSpell"/> y <see cref="RemoveSpell"/>.
        /// </summary>
        public ReadOnlyCollection<Spell> Spells => readOnlySpells;

        /// <summary>
        /// Agrega un hechizo al libro.
        /// </summary>
        /// <param name="spell">El hechizo a agregar.</param>
        public void AddSpell(Spell spell)
        {
            ArgumentNullException.ThrowIfNull(spell);

            spells.Add(spell);
            AttackValue += spell.AttackValue;
            DefenseValue += spell.DefenseValue;
        }

        /// <summary>
        /// Elimina un hechizo del libro.
        /// </summary>
        /// <param name="spell">El hechizo a eliminar.</param>
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
