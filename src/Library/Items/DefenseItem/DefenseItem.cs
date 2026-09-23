//--------------------------------------------------------------------------------
// <copyright file="DefenseItem.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items.DefenseItem
{
    /// <summary>
    /// Representa un elemento de defensa: solo permite defender ataques.
    /// </summary>
    public abstract class DefenseItem : Item
    {
        /// <summary>
        /// El valor de defensa del elemento.
        /// </summary>
        public int DefenseValue { get; protected set; }
        
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="DefenseItem"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="defenseValue">El valor de defensa del elemento.</param>
        /// <param name="magic">Indica si el elemento es mágico.</param>
        protected DefenseItem(string name, int defenseValue, bool magic)
            : base(name, magic)
        {
            this.DefenseValue = defenseValue;
        }
    }
}
