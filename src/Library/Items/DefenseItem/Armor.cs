//--------------------------------------------------------------------------------
// <copyright file="Armor.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items
{
    /// <summary>
    /// Representa una armadura. Es un elemento de defensa.
    /// </summary>
    public class Armor : DefenseItem
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Armor"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="defenseValue">El valor de defensa.</param>
        public Armor(string name, int defenseValue)
            : base(name, defenseValue)
        {
        }
    }
}
