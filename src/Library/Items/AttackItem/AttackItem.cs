//--------------------------------------------------------------------------------
// <copyright file="AttackItem.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items
{
    /// <summary>
    /// Representa un arma: un elemento que solo permite atacar.
    /// </summary>
    public abstract class AttackItem : Item
    {
        private readonly int attackValue;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="AttackItem"/>.
        /// </summary>
        /// <param name="name">El nombre del arma.</param>
        /// <param name="attackValue">El valor de ataque del arma.</param>
        protected AttackItem(string name, int attackValue)
            : base(name)
        {
            this.attackValue = attackValue;
        }

        /// <inheritdoc/>
        public override int AttackValue => attackValue;
    }
}
