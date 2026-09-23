//--------------------------------------------------------------------------------
// <copyright file="Dwarf.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
//--------------------------------------------------------------------------------

using System;
using Library.Items;
using Library.Items.AttackDefenseItem;
using Library.Items.AttackItem;
using Library.Items.DefenseItem;

namespace Library.Characters
{
    /// <summary>
    /// Representa un personaje de tipo Enano (Dwarf).
    /// </summary>
    public class Dwarf : Character
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Dwarf"/>.
        /// </summary>
        public Dwarf(string name, int health, int baseAttack, int baseDefense)
            : base(name, health, baseAttack, baseDefense)
        {
        }

        /// <summary>
        /// Obtiene o establece el hacha del enano.
        /// </summary>
        public Axe Axe { get; protected set; }

        /// <summary>
        /// Obtiene o establece el escudo del enano.
        /// </summary>
        public Shield Shield { get; protected set; }

        /// <summary>
        /// Obtiene o establece el arco del enano.
        /// </summary>
        public Bow Bow { get; protected set; }

        /// <summary>
        /// Obtiene o establece el casco del enano.
        /// </summary>
        public Helmet Helmet { get; protected set; }
        
        /// <summary>
        /// Obtiene el valor total de ataque del enano, incluyendo su ataque base y los valores de ataque de los elementos equipados.
        /// </summary>
        /// <returns></returns>
        public override int GetAttackValue()
        {
            int total = BaseAttack;

            if (Axe != null)
            {
                total += Axe.AttackValue;
            }

            if (Bow != null)
            {
                total += Bow.AttackValue;
            }

            return total;
        }

        /// <summary>
        /// Obtiene el valor total de defensa del enano, incluyendo su defensa base y los valores de defensa de los elementos equipados.
        /// </summary>
        /// <returns></returns>
        public override int GetDefenseValue()
        {
            int total = BaseDefense;

            if (Shield != null)
            {
                total += Shield.DefenseValue;
            }

            if (Helmet != null)
            {
                total += Helmet.DefenseValue;
            }

            return total;
        }

        /// <summary>
        /// Equipa un hacha al enano.
        /// </summary>
        /// <param name="axe"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void EquipAxe(Axe axe)
        {
            if (axe == null)
            {
                throw new ArgumentNullException(nameof(axe), "El hacha no puede ser nula.");
            }

            Axe = axe;
        }

        /// <summary>
        /// Equipa un escudo al enano.
        /// </summary>
        /// <param name="shield"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void EquipShield(Shield shield)
        {
            if (shield == null)
            {
                throw new ArgumentNullException(nameof(shield), "El escudo no puede ser nulo.");
            }

            Shield = shield;
        }

        /// <summary>
        /// Equipa un arco al enano.
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
        /// Equipa un casco al enano.
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
        /// Libera el hacha del enano.
        /// </summary>
        public void UnequipAxe()
        {
            Axe = null;
        }

        /// <summary>
        /// Libera el escudo del enano.
        /// </summary>
        public void UnequipShield()
        {
            Shield = null;
        }

        /// <summary>
        /// Libera el arco del enano.
        /// </summary>
        public void UnequipBow()
        {
            Bow = null;
        }

        /// <summary>
        /// Libera el casco del enano.
        /// </summary>
        public void UnequipHelmet()
        {
            Helmet = null;
        }

        /// <summary>
        /// El enano equipa un elemento, ya sea un hacha, un escudo, un arco o un casco.
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="ArgumentException"></exception>
        public void GetItem(Item item)
        {
            Axe axe = item as Axe;
            if (axe != null)
            {
                EquipAxe(axe);
                return;
            }

            Shield shield = item as Shield;
            if (shield != null)
            {
                EquipShield(shield);
                return;
            }

            Bow bow = item as Bow;
            if (bow != null)
            {
                EquipBow(bow);
                return;
            }

            Helmet helmet = item as Helmet;
            if (helmet != null)
            {
                EquipHelmet(helmet);
                return;
            }

            throw new ArgumentException("El enano solo puede equipar Axe, Shield, Bow o Helmet.", nameof(item));
        }

        /// <summary>
        /// El enano libera un elemento, ya sea un hacha, un escudo, un arco o un casco.
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="ArgumentException"></exception>
        public void DropItem(Item item)
        {
            if (item is Axe)
            {
                Axe = null;
                return;
            }

            if (item is Shield)
            {
                Shield = null;
                return;
            }

            if (item is Bow)
            {
                Bow = null;
                return;
            }

            if (item is Helmet)
            {
                Helmet = null;
                return;
            }

            throw new ArgumentException("El enano solo puede desequipar Axe, Shield, Bow o Helmet.", nameof(item));
        }
    }
}