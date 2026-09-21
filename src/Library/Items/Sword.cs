//--------------------------------------------------------------------------------
// <copyright file="Sword.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items
{
    /// <summary>
    /// Representa una espada. Es un arma.
    /// </summary>
    public class Sword : AttackItem
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Sword"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="attackValue">El valor de ataque.</param>
        public Sword(string name, int attackValue)
            : base(name, attackValue)
        {
        }
    }
}
