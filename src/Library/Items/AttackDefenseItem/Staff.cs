//--------------------------------------------------------------------------------
// <copyright file="Staff.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items.AttackDefenseItem
{
    /// <summary>
    /// Representa un báculo. Es un elemento mágico que ataca y defiende.
    /// </summary>
    public class Staff : AttackDefenseItem
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Staff"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="attackValue">El valor de ataque.</param>
        /// <param name="defenseValue">El valor de defensa.</param>
        public Staff(string name, int attackValue, int defenseValue)
            : base(name, attackValue, defenseValue, true)
        {
        }
    }
}
