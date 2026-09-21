//--------------------------------------------------------------------------------
// <copyright file="Helmet.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items
{
    /// <summary>
    /// Representa un casco. Es un elemento de defensa.
    /// </summary>
    public class Helmet : DefenseItem
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Helmet"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="defenseValue">El valor de defensa.</param>
        public Helmet(string name, int defenseValue)
            : base(name, defenseValue)
        {
        }
    }
}
