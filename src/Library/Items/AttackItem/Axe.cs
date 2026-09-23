//--------------------------------------------------------------------------------
// <copyright file="Axe.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items
{
    /// <summary>
    /// Representa un hacha. Es un arma.
    /// </summary>
    public class Axe : AttackItem
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Axe"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="attackValue">El valor de ataque.</param>
        public Axe(string name, int attackValue)
            : base(name, attackValue)
        {
        }
    }
}
