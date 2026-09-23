//--------------------------------------------------------------------------------
// <copyright file="AttackItem.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items.AttackItem
{
    /// <summary>
    /// Representa un arma: un elemento que solo permite atacar.
    /// </summary>
    public abstract class AttackItem : Item
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="AttackItem"/>.
        /// </summary>
        /// <param name="name">El nombre del arma.</param>
        /// <param name="attackValue">El valor de ataque del arma.</param>
        /// <param name="magic">Indica si el arma es mágica.</param>
        protected AttackItem(string name, int attackValue, bool magic)
            : base(name, attackValue, 0, magic)
        {
        }
    }
}
