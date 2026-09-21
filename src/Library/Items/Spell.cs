//--------------------------------------------------------------------------------
// <copyright file="Spell.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items
{
    /// <summary>
    /// Representa un hechizo individual con capacidades mágicas de ataque y defensa.
    /// </summary>
    public class Spell : Item
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Spell"/>.
        /// </summary>
        /// <param name="name">El nombre del hechizo.</param>
        /// <param name="attackValue">El valor de ataque mágico del hechizo.</param>
        /// <param name="defenseValue">El valor de defensa mágica del hechizo.</param>
        public Spell(string name, int attackValue, int defenseValue)
            : base(name, attackValue, defenseValue)
        {
        }
    }
}
