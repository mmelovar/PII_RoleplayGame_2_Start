//--------------------------------------------------------------------------------
// <copyright file="Item.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items
{
    /// <summary>
    /// Representa un elemento del juego. Por defecto no aporta ataque ni defensa;
    /// cada subclase sobrescribe los valores que sí aporta.
    /// </summary>
    public abstract class Item
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Item"/>.
        /// </summary>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="attackValue">El valor de ataque del elemento.</param>
        /// <param name="defenseValue">El valor de defensa del elemento.</param>
        /// <param name="magic">Indica si el elemento es mágico.</param>
        protected Item(string name, int attackValue, int defenseValue, bool magic)
        {
            Name = name;
            IsMagical = magic;
            AttackValue = attackValue;
            DefenseValue = defenseValue;
        }

        /// <summary>
        /// Obtiene el nombre del elemento.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Define si el elemento es mágico o no.
        /// </summary>
        public bool IsMagical { get; protected set; }

        /// <summary>
        /// Obtiene el valor de ataque del elemento.
        /// </summary>
        public int AttackValue { get; protected set; }
        
        /// <summary>
        /// Obtiene el valor de defensa del elemento.
        /// </summary>
        public int DefenseValue { get; protected set; }

    }
}
