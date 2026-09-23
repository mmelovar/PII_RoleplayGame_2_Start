//--------------------------------------------------------------------------------
// <copyright file="Shield.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items.DefenseItem
{
    /// <summary>
    /// Representa un escudo. Es un elemento de defensa.
    /// </summary>
    public class Shield : DefenseItem
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Shield"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="defenseValue">El valor de defensa.</param>
        public Shield(string name, int defenseValue)
            : base(name, defenseValue, false)
        {
        }
    }
}
