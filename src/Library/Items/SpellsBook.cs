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
    /// Representa un libro de hechizos. Su ataque y su defensa son la suma de
    /// los hechizos que contiene.
    /// </summary>
    public class SpellsBook : MagicalItem
    {
        private readonly List<Spell> spells = new List<Spell>();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="SpellsBook"/>.
        /// </summary>
        /// <param name="name">El nombre del libro.</param>
        public SpellsBook(string name)
            : base(name, 0, 0)
        {
        }

        /// <summary>
        /// Obtiene los hechizos del libro. Es de solo lectura: para modificarla
        /// se usan <see cref="AddSpell"/> y <see cref="RemoveSpell"/>.
        /// </summary>
        public IReadOnlyList<Spell> Spells => spells.AsReadOnly();

        /// <inheritdoc/>
        public override int AttackValue
        {
            get
            {
                int total = 0;
                foreach (Spell spell in spells)
                {
                    total += spell.AttackValue;
                }

                return total;
            }
        }

        /// <inheritdoc/>
        public override int DefenseValue
        {
            get
            {
                int total = 0;
                foreach (Spell spell in spells)
                {
                    total += spell.DefenseValue;
                }

                return total;
            }
        }

        /// <summary>
        /// Agrega un hechizo al libro.
        /// </summary>
        /// <param name="spell">El hechizo a agregar.</param>
        public void AddSpell(Spell spell)
        {
            if (spell == null)
            {
                throw new ArgumentNullException(nameof(spell));
            }

            spells.Add(spell);
        }

        /// <summary>
        /// Quita un hechizo del libro.
        /// </summary>
        /// <param name="spell">El hechizo a quitar.</param>
        public void RemoveSpell(Spell spell)
        {
            if (spell == null)
            {
                throw new ArgumentNullException(nameof(spell));
            }

            spells.Remove(spell);
        }
    }
}
