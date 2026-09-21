//--------------------------------------------------------------------------------
// <copyright file="WizardTests.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Library.Characters;
using Library.Items;
using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
    /// <summary>
    /// Pruebas unitarias para la clase Wizard y sus elementos asociados (Staff, Spell, SpellsBook).
    /// </summary>
    public class WizardTests
    {
        private Wizard gandalf;
        private Staff staff;
        private SpellsBook spellsBook;
        private Spell fireball;
        private Spell shieldSpell;

        /// <summary>
        /// Configuración inicial antes de cada prueba.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.gandalf = new Wizard("Gandalf", 100, 20, 10);
            this.staff = new Staff("Bastón de la Luz", 40, 15);
            this.spellsBook = new SpellsBook("Libro de Hechizos Antiguo");
            this.fireball = new Spell("Bola de Fuego", 50, 0);
            this.shieldSpell = new Spell("Escudo Arcano", 10, 30);
        }

        /// <summary>
        /// Verifica que el ataque de un mago sin items sea igual a su ataque base.
        /// </summary>
        [Test]
        public void GetAttackValue_WithoutItems_ReturnsBaseAttack()
        {
            int expectedAttack = 20;
            Assert.That(this.gandalf.GetAttackValue(), Is.EqualTo(expectedAttack));
        }

        /// <summary>
        /// Verifica que el ataque incluya el poder del báculo cuando está equipado.
        /// </summary>
        [Test]
        public void GetAttackValue_WithStaff_ReturnsBasePlusStaffAttack()
        {
            this.gandalf.SetItem(this.staff);

            int expectedAttack = 20 + 40; // Base + Staff
            Assert.That(this.gandalf.GetAttackValue(), Is.EqualTo(expectedAttack));
        }

        /// <summary>
        /// Verifica que el libro de hechizos sume el poder de los hechizos que contiene.
        /// </summary>
        [Test]
        public void SpellsBook_AddingSpells_CalculatesCumulativeAttackAndDefense()
        {
            this.spellsBook.AddSpell(this.fireball);
            this.spellsBook.AddSpell(this.shieldSpell);

            Assert.That(this.spellsBook.AttackValue, Is.EqualTo(60)); // 50 + 10
            Assert.That(this.spellsBook.DefenseValue, Is.EqualTo(30)); // 0 + 30
        }

        /// <summary>
        /// Verifica que el mago calcule correctamente su ataque total con báculo y libro de hechizos.
        /// </summary>
        [Test]
        public void GetAttackValue_WithStaffAndSpellsBook_ReturnsCombinedAttack()
        {
            this.spellsBook.AddSpell(this.fireball);
            this.spellsBook.AddSpell(this.shieldSpell);

            this.gandalf.SetItem(this.staff);
            this.gandalf.SetItem(this.spellsBook);

            int expectedAttack = 20 + 40 + 60; // Base (20) + Staff (40) + SpellsBook (60)
            Assert.That(this.gandalf.GetAttackValue(), Is.EqualTo(expectedAttack));
        }

        /// <summary>
        /// Verifica que la defensa total sume la base, la del báculo y la del libro de hechizos.
        /// </summary>
        [Test]
        public void GetDefenseValue_WithStaffAndSpellsBook_ReturnsCombinedDefense()
        {
            this.spellsBook.AddSpell(this.shieldSpell);

            this.gandalf.SetItem(this.staff);
            this.gandalf.SetItem(this.spellsBook);

            int expectedDefense = 10 + 15 + 30; // Base (10) + Staff (15) + SpellsBook (30)
            Assert.That(this.gandalf.GetDefenseValue(), Is.EqualTo(expectedDefense));
        }

        /// <summary>
        /// Verifica que al remover un hechizo del libro, su ataque y defensa se actualicen.
        /// </summary>
        [Test]
        public void SpellsBook_RemovingSpell_DecreasesPower()
        {
            this.spellsBook.AddSpell(this.fireball);
            this.spellsBook.AddSpell(this.shieldSpell);
            this.spellsBook.RemoveSpell(this.fireball);

            Assert.That(this.spellsBook.AttackValue, Is.EqualTo(10));
            Assert.That(this.spellsBook.DefenseValue, Is.EqualTo(30));
        }

        /// <summary>
        /// Verifica que al desequipar un item con DropItem, el mago deje de tenerlo y su ataque disminuya.
        /// </summary>
        [Test]
        public void DropItem_EquippedStaff_RemovesStaffAndReducesAttack()
        {
            this.gandalf.SetItem(this.staff);
            Assert.That(this.gandalf.Staff, Is.EqualTo(this.staff));

            this.gandalf.DropItem(this.staff);
            Assert.That(this.gandalf.Staff, Is.Null);
            Assert.That(this.gandalf.GetAttackValue(), Is.EqualTo(20));
        }

        /// <summary>
        /// Verifica que intentar equipar un item no permitido para el mago lance una excepción.
        /// </summary>
        [Test]
        public void SetItem_InvalidItem_ThrowsArgumentException()
        {
            Sword genericItem = new Sword("Espada", 15, 0);

            Assert.Throws<ArgumentException>(() => this.gandalf.SetItem(genericItem));
        }
    }
}
