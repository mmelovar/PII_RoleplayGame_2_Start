//--------------------------------------------------------------------------------
// <copyright file="Dwarf.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Characters
{
    /// <summary>
    /// Representa un enano. No puede usar elementos mágicos.
    /// </summary>
    public class Dwarf : Character
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Dwarf"/>.
        /// </summary>
        /// <param name="name">El nombre del enano.</param>
        /// <param name="health">La vida inicial.</param>
        /// <param name="baseAttack">El ataque sin elementos.</param>
        /// <param name="baseDefense">La defensa sin elementos.</param>
        public Dwarf(string name, int health, int baseAttack, int baseDefense)
            : base(name, health, baseAttack, baseDefense)
        {
        }
    }
}
