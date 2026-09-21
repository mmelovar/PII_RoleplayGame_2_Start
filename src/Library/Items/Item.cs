//--------------------------------------------------------------------------------
// <copyright file="Item.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

namespace Library.Items
{
    /// <summary>
    /// Representa un elemento o equipamiento del juego.
    /// </summary>
    public abstract class Item
    {
        public string Name { get; protected set; }

        public int AttackValue { get; protected set; }

        public int DefenseValue { get; protected set; }

        protected Item(string name, int attackValue, int defenseValue)
        {
            Name = name;
            AttackValue = attackValue;
            DefenseValue = defenseValue;
        }
    }
}
