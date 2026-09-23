//--------------------------------------------------------------------------------
// <copyright file="Bow.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items.AttackItem
{
    /// <summary>
    /// Representa un arco. Es un arma.
    /// </summary>
    public class Bow : AttackItem
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Bow"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="attackValue">El valor de ataque.</param>
        public Bow(string name, int attackValue)
            : base(name, attackValue, false)
        {
        }
    }
}
