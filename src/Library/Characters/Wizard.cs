//--------------------------------------------------------------------------------
// <copyright file="Wizard.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

//--------------------------------------------------------------------------------
// <copyright file="Wizard.cs" company="Universidad Católica del Uruguay">
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
    /// Representa un personaje de tipo Mago (Wizard).
    /// </summary>
    public class Wizard : Character
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Wizard"/>.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="baseAttack"></param>
        /// <param name="baseDefense"></param>
        public Wizard(string name, int health, int baseAttack, int baseDefense)
            : base(name, health, baseAttack, baseDefense)
        {
        }

        /// <summary>
        /// Obtiene o establece el bastón del mago.
        /// </summary>
        public Staff Staff { get; protected set; }

        /// <summary>
        /// Obtiene o establece el libro de hechizos del mago.
        /// </summary>
        public SpellsBook SpellsBook { get; protected set; }

        /// <summary>
        /// Obtiene el valor total de ataque del mago, incluyendo su ataque base y los valores de ataque de los elementos equipados.
        /// </summary>
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

        /// <summary>
        /// Obtiene el valor total de defensa del mago, incluyendo su defensa base y los valores de defensa de los elementos equipados.
        /// </summary>
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

        /// <summary>
        /// Establece un elemento para el mago, ya sea un bastón o un libro de hechizos.
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void SetItem(Item item)
        {
            ArgumentNullException.ThrowIfNull(item, "El item no puede ser nulo.");

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

        /// <summary>
        /// Obtiene un elemento para el mago.
        /// </summary>
        /// <param name="item"></param>
        public void GetItem(Item item)
        {
            SetItem(item);
        }

        /// <summary>
        /// Libera un elemento del mago.
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void DropItem(Item item)
        {
            ArgumentNullException.ThrowIfNull(item, "El item no puede ser nulo.");

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