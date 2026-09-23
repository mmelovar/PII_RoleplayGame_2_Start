using System;
using NUnit.Framework;
using Library.Characters;
using Library.Items;

namespace LibraryTests.Characters
{
    public class DwarfTest
    {
        [Test]
        public void DwarfHasCorrectBaseStats()
        {
            var dwarf = new Dwarf("Alonso", 100, 10, 5);

            Assert.That(dwarf.Name, Is.EqualTo("Alonso"));
            Assert.That(dwarf.Health, Is.EqualTo(100));
            Assert.That(dwarf.MaxHealth, Is.EqualTo(100));
            Assert.That(dwarf.BaseAttack, Is.EqualTo(10));
            Assert.That(dwarf.BaseDefense, Is.EqualTo(5));
        }

        [Test]
        public void DwarfAttackValueIncludesEquippedItems()
        {
            var dwarf = new Dwarf("Alonso", 100, 10, 5);

            dwarf.AddItem(new Axe("Axe of Destiny", 5));
            dwarf.AddItem(new Bow("Bow of Light", 3));

            Assert.That(dwarf.GetAttackValue(), Is.EqualTo(18));
        }

        [Test]
        public void DwarfDefenseValueIncludesEquippedItems()
        {
            var dwarf = new Dwarf("Alonso", 100, 10, 5);

            dwarf.AddItem(new Shield("Iron Shield", 7));
            dwarf.AddItem(new Helmet("Bronze Helmet", 4));

            Assert.That(dwarf.GetDefenseValue(), Is.EqualTo(16));
        }

        [Test]
        public void DwarfUnequipsItemAndLowersTotal()
        {
            var dwarf = new Dwarf("Alonso", 100, 10, 5);
            var axe = new Axe("Axe of Destiny", 5);

            dwarf.AddItem(axe);
            Assert.That(dwarf.GetAttackValue(), Is.EqualTo(15));

            dwarf.RemoveItem(axe);
            Assert.That(dwarf.GetAttackValue(), Is.EqualTo(10));
        }

        [Test]
        public void DwarfReceivesAttack_WhenAttacked_ReducesHealth()
        {
            var dwarf = new Dwarf("Alonso", 100, 10, 5);

            dwarf.ReceiveAttack(20);

            Assert.That(dwarf.Health, Is.EqualTo(85));
        }

        [Test]
        public void DwarfCure_DoesNotExceedMaxHealth()
        {
            var dwarf = new Dwarf("Alonso", 100, 10, 5);

            dwarf.ReceiveAttack(90);
            dwarf.Cure(50);

            Assert.That(dwarf.Health, Is.EqualTo(65));
        }

        [Test]
        public void AddItem_MagicalItem_ThrowsArgumentException()
        {
            var dwarf = new Dwarf("Alonso", 100, 10, 5);

            Assert.Throws<ArgumentException>(() => dwarf.AddItem(new Staff("Bastón", 40, 15)));
            Assert.That(dwarf.Items, Is.Empty);
        }

        [Test]
        public void ReceiveAttack_DamageGreaterThanHealth_HealthStaysAtZero()
        {
            var dwarf = new Dwarf("Alonso", 100, 10, 5);

            dwarf.ReceiveAttack(500);

            Assert.That(dwarf.Health, Is.EqualTo(0));
        }

        [Test]
        public void Attack_AttackerWithoutHealth_DoesNotDamageTarget()
        {
            var attacker = new Dwarf("Alonso", 100, 10, 5);
            var target = new Dwarf("Gimli", 100, 10, 5);

            attacker.ReceiveAttack(500);
            attacker.Attack(target);

            Assert.That(target.Health, Is.EqualTo(100));
        }

        [Test]
        public void Attack_NullTarget_ThrowsArgumentNullException()
        {
            var dwarf = new Dwarf("Alonso", 100, 10, 5);

            Assert.Throws<ArgumentNullException>(() => dwarf.Attack(null));
        }
    }
}
