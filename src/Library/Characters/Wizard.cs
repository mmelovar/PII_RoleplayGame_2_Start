//--------------------------------------------------------------------------------
// <copyright file="Wizard.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Characters
{
    /// <summary>
    /// Representa un mago. A diferencia del resto de los personajes, puede usar
    /// elementos mágicos.
    /// </summary>
    public class Wizard : Character
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Wizard"/>.
        /// </summary>
        /// <param name="name">El nombre del mago.</param>
        /// <param name="health">La vida inicial.</param>
        /// <param name="baseAttack">El ataque sin elementos.</param>
        /// <param name="baseDefense">La defensa sin elementos.</param>
        public Wizard(string name, int health, int baseAttack, int baseDefense)
            : base(name, health, baseAttack, baseDefense)
        {
        }

        /// <inheritdoc/>
        protected override bool CanUseMagicalItems => true;
    }
}
