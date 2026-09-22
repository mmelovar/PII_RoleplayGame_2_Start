//--------------------------------------------------------------------------------
// <copyright file="DefenseItem.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items
{
    /// <summary>
    /// Representa un elemento de defensa: solo permite defender ataques.
    /// </summary>
    public abstract class DefenseItem : Item
    {
        private readonly int defenseValue;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DefenseItem"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="defenseValue">El valor de defensa del elemento.</param>
        protected DefenseItem(string name, int defenseValue)
            : base(name)
        {
            this.defenseValue = defenseValue;
        }

        /// <inheritdoc/>
        public override int DefenseValue => defenseValue;
    }
}
