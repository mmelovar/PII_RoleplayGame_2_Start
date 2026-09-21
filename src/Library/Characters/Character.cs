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
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int MaxHealth { get; protected set; }
        public int BaseAttack { get; protected set; }
        public int BaseDefense { get; protected set; }

        protected Character(string name, int health, int baseAttack, int baseDefense)
        {
            Name = name;
            MaxHealth = health;
            Health = health;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
        }

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

        public abstract int GetAttackValue();
        public abstract int GetDefenseValue();
    }
}