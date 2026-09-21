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
        protected Item(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Obtiene el nombre del elemento.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Obtiene el valor de ataque que aporta el elemento.
        /// </summary>
        public virtual int AttackValue => 0;

        /// <summary>
        /// Obtiene el valor de defensa que aporta el elemento.
        /// </summary>
        public virtual int DefenseValue => 0;
    }
}
