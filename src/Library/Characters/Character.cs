//--------------------------------------------------------------------------------
// <copyright file="Character.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace Library.Characters
{
    /// <summary>
    /// Representa un personaje base del juego.
    /// </summary>
    public abstract class Character
    {
        /// <summary>
        /// Obtiene o establece el nombre del personaje.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Obtiene o establece la salud actual del personaje.
        /// </summary>
        public int Health { get; protected set; }

        /// <summary>
        /// Obtiene o establece la salud máxima del personaje.
        /// </summary>
        public int MaxHealth { get; protected set; }

        /// <summary>
        /// Obtiene o establece el valor de ataque base del personaje.
        /// </summary>
        public int BaseAttack { get; protected set; }

        /// <summary>
        /// Obtiene o establece el valor de defensa base del personaje.
        /// </summary>
        public int BaseDefense { get; protected set; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Character"/>.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="baseAttack"></param>
        /// <param name="baseDefense"></param>
        protected Character(string name, int health, int baseAttack, int baseDefense)
        {
            Name = name;
            MaxHealth = health;
            Health = health;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
        }

        /// <summary>
        /// Recibe un ataque de otro personaje.
        /// </summary>
        /// <param name="power"></param>
        public virtual void ReceiveAttack(int power)
        {
            if (power <= 0)
            {
                return;
            }

            int damage = power - GetDefenseValue();

            if (damage <= 0)
            {
                return;
            }

            Health -= damage;

            if (Health < 0)
            {
                Health = 0;
            }
        }

        /// <summary>
        /// Cura al personaje, aumentando su salud en la cantidad especificada.
        /// </summary>
        /// <param name="points"></param>
        public virtual void Cure(int points)
        {
            if (points <= 0)
            {
                return;
            }

            if (Health + points >= MaxHealth)
            {
                Health = MaxHealth;
                return;
            }

            Health += points;
        }

        /// <summary>
        /// Obtiene el valor total de ataque del personaje, incluyendo su ataque base y los valores de ataque de los elementos equipados.
        /// </summary>
        /// <param name="target"></param>
        public virtual void Attack(Character target)
        {
            if (target == null)
            {
                ArgumentNullException.ThrowIfNull(target);
            }

            if (Health <= 0)
            {
                return;
            }

            target.ReceiveAttack(GetAttackValue());
        }

        /// <summary>
        /// Obtiene el valor total de ataque del personaje, incluyendo su ataque base y los valores de ataque de los elementos equipados.
        /// </summary>
        /// <returns></returns>
        public abstract int GetAttackValue();

        /// <summary>
        /// Obtiene el valor total de defensa del personaje, incluyendo su defensa base y los valores de defensa de los elementos equipados.
        /// </summary>
        /// <returns></returns>
        public abstract int GetDefenseValue();
    }
}