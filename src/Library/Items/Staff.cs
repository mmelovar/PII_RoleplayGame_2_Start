//--------------------------------------------------------------------------------
// <copyright file="Staff.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items
{
    /// <summary>
    /// Representa un báculo mágico (Staff) que puede ser utilizado por magos.
    /// </summary>
    public class Staff : Item
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Staff"/>.
        /// </summary>
        /// <param name="name">El nombre del báculo.</param>
        /// <param name="attackValue">El valor de ataque del báculo.</param>
        /// <param name="defenseValue">El valor de defensa del báculo.</param>
        public Staff(string name, int attackValue, int defenseValue)
            : base(name, attackValue, defenseValue)
        {
        }
    }
}
