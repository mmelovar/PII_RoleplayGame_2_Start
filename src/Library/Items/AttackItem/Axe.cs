//--------------------------------------------------------------------------------
// <copyright file="Axe.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace Library.Items
{
    /// <summary>
    /// Representa un hacha (Axe) que puede ser utilizada por los enanos.
    /// </summary>
    public class Axe : Item
    {
        public Axe(string name, int attackValue, int defenseValue)
            : base(name, attackValue, defenseValue)
        {
        }
    }
}

