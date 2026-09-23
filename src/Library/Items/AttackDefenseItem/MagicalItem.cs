//--------------------------------------------------------------------------------
// <copyright file="MagicalItem.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items
{
    /// <summary>
    /// Representa un elemento mágico. Sirve para atacar y defender, pero solo
    /// los magos pueden usarlo.
    /// </summary>
    public abstract class MagicalItem : AttackDefenseItem
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="MagicalItem"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="attackValue">El valor de ataque del elemento.</param>
        /// <param name="defenseValue">El valor de defensa del elemento.</param>
        protected MagicalItem(string name, int attackValue, int defenseValue)
            : base(name, attackValue, defenseValue)
        {
        }
    }
}
