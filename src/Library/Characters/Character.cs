//--------------------------------------------------------------------------------
// <copyright file="Character.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Library.Items;

namespace Library.Characters
{
    /// <summary>
    /// Representa un personaje del juego. Todos los personajes manejan un nivel
    /// de vida, pueden ser atacados, pueden ser curados y pueden tener elementos.
    /// </summary>
    public abstract class Character
    {
        private readonly List<Item> items = new List<Item>();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Character"/>.
        /// </summary>
        /// <param name="name">El nombre del personaje.</param>
        /// <param name="health">La vida inicial, que también es la vida máxima.</param>
        /// <param name="baseAttack">El ataque del personaje sin elementos.</param>
        /// <param name="baseDefense">La defensa del personaje sin elementos.</param>
        protected Character(string name, int health, int baseAttack, int baseDefense)
        {
            Name = name;
            MaxHealth = health;
            Health = health;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
        }

        /// <summary>
        /// Obtiene el nombre del personaje.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Obtiene la vida actual del personaje.
        /// </summary>
        public int Health { get; private set; }

        /// <summary>
        /// Obtiene la vida máxima del personaje.
        /// </summary>
        public int MaxHealth { get; }

        /// <summary>
        /// Obtiene el ataque del personaje sin elementos.
        /// </summary>
        public int BaseAttack { get; }

        /// <summary>
        /// Obtiene la defensa del personaje sin elementos.
        /// </summary>
        public int BaseDefense { get; }

        /// <summary>
        /// Obtiene los elementos del personaje. Es de solo lectura: para
        /// modificarla se usan <see cref="AddItem"/> y <see cref="RemoveItem"/>.
        /// </summary>
        public IReadOnlyList<Item> Items => items.AsReadOnly();

        /// <summary>
        /// Obtiene un valor que indica si el personaje puede usar elementos
        /// mágicos. Por defecto no puede; los magos sobrescriben esta propiedad.
        /// </summary>
        protected virtual bool CanUseMagicalItems => false;

        /// <summary>
        /// Agrega un elemento al personaje.
        /// </summary>
        /// <param name="item">El elemento a agregar.</param>
        /// <exception cref="ArgumentException">Si el elemento es mágico y el
        /// personaje no puede usar elementos mágicos.</exception>
        public void AddItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (item is MagicalItem && !CanUseMagicalItems)
            {
                throw new ArgumentException("Solo los magos pueden usar elementos mágicos.", nameof(item));
            }

            if (!items.Contains(item))
            {
                items.Add(item);
            }
        }

        /// <summary>
        /// Quita un elemento del personaje.
        /// </summary>
        /// <param name="item">El elemento a quitar.</param>
        public void RemoveItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            items.Remove(item);
        }

        /// <summary>
        /// Calcula el ataque total: el ataque base más el de todos los elementos.
        /// </summary>
        /// <returns>El valor de ataque total.</returns>
        public int GetAttackValue()
        {
            int total = BaseAttack;
            foreach (Item item in items)
            {
                total += item.AttackValue;
            }

            return total;
        }

        /// <summary>
        /// Calcula la defensa total: la defensa base más la de todos los elementos.
        /// </summary>
        /// <returns>El valor de defensa total.</returns>
        public int GetDefenseValue()
        {
            int total = BaseDefense;
            foreach (Item item in items)
            {
                total += item.DefenseValue;
            }

            return total;
        }

        /// <summary>
        /// Recibe un ataque. El daño es el poder del ataque menos la defensa
        /// total; la vida nunca baja de cero.
        /// </summary>
        /// <param name="power">El poder del ataque.</param>
        public void ReceiveAttack(int power)
        {
            int damage = power - GetDefenseValue();
            if (damage <= 0)
            {
                return;
            }

            Health = Math.Max(Health - damage, 0);
        }

        /// <summary>
        /// Cura al personaje; la vida nunca supera la vida máxima.
        /// </summary>
        /// <param name="points">Los puntos de vida a recuperar.</param>
        public void Cure(int points)
        {
            if (points <= 0)
            {
                return;
            }

            Health = Math.Min(Health + points, MaxHealth);
        }

        /// <summary>
        /// Ataca a otro personaje con el ataque total. Un personaje sin vida no
        /// puede atacar.
        /// </summary>
        /// <param name="target">El personaje atacado.</param>
        public void Attack(Character target)
        {
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            if (Health <= 0)
            {
                return;
            }

            target.ReceiveAttack(GetAttackValue());
        }
    }
}
