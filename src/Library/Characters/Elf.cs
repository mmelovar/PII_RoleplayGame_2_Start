//--------------------------------------------------------------------------------
// <copyright file="Elf.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Characters
{
    /// <summary>
    /// Representa un elfo. No puede usar elementos mágicos.
    /// </summary>
    public class Elf : Character
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Elf"/>.
        /// </summary>
        /// <param name="name">El nombre del elfo.</param>
        /// <param name="health">La vida inicial.</param>
        /// <param name="baseAttack">El ataque sin elementos.</param>
        /// <param name="baseDefense">La defensa sin elementos.</param>
        public Elf(string name, int health, int baseAttack, int baseDefense)
            : base(name, health, baseAttack, baseDefense)
        {
        }
    }
}
