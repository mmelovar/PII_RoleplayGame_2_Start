//--------------------------------------------------------------------------------
// <copyright file="Spell.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items
{
    /// <summary>
    /// Representa un hechizo. Es un elemento mágico que ataca y defiende.
    /// </summary>
    public class Spell : MagicalItem
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Spell"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="attackValue">El valor de ataque.</param>
        /// <param name="defenseValue">El valor de defensa.</param>
        public Spell(string name, int attackValue, int defenseValue)
            : base(name, attackValue, defenseValue)
        {
        }
    }
}
