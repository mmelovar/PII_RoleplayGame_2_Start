//--------------------------------------------------------------------------------
// <copyright file="AttackDefenseItem.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items
{
    /// <summary>
    /// Representa un elemento que permite atacar y también defender.
    /// </summary>
    public abstract class AttackDefenseItem : Item
    {
        private readonly int attackValue;
        private readonly int defenseValue;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="AttackDefenseItem"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="attackValue">El valor de ataque del elemento.</param>
        /// <param name="defenseValue">El valor de defensa del elemento.</param>
        protected AttackDefenseItem(string name, int attackValue, int defenseValue)
            : base(name)
        {
            this.attackValue = attackValue;
            this.defenseValue = defenseValue;
        }

        /// <inheritdoc/>
        public override int AttackValue => attackValue;

        /// <inheritdoc/>
        public override int DefenseValue => defenseValue;
    }
}
