//--------------------------------------------------------------------------------
// <copyright file="Shield.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace Library.Items
{
    /// <summary>
    /// Representa un escudo (Shield) que puede ser utilizado por los guerreros.
    /// </summary>
    public class Shield : Item
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Shield"/>.
        /// </summary>
        /// <param name="name">El nombre del escudo.</param>
        /// <param name="attackValue">El valor de ataque del escudo.</param>
        /// <param name="defenseValue">El valor de defensa del escudo.</param>
        public Shield(string name, int attackValue, int defenseValue)
            : base(name, attackValue, defenseValue)
        {
        }
    }
}