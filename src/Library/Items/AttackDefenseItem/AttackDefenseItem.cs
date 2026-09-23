//--------------------------------------------------------------------------------
// <copyright file="AttackDefenseItem.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items.AttackDefenseItem
{
    /// <summary>
    /// Representa un elemento que permite atacar y también defender.
    /// </summary>
    /// <remarks>
    /// Un elemento de ataque y defensa es un tipo de elemento que tiene un valor de ataque y un valor de defensa.
    /// </remarks>
    public abstract class AttackDefenseItem : Item
    {  
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="AttackDefenseItem"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="attackValue">El valor de ataque del elemento.</param>
        /// <param name="defenseValue">El valor de defensa del elemento.</param>
        /// <param name="magic">Indica si el elemento es mágico.</param>
        protected AttackDefenseItem(string name, int attackValue, int defenseValue, bool magic)
            : base(name, attackValue, defenseValue, magic)
        {
        }
    }
}
