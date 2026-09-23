using System;
using NUnit.Framework;
using Library.Characters;
using Library.Items;
using Library.Items.AttackItem;
using Library.Items.DefenseItem;
using Library.Items.AttackDefenseItem;

namespace LibraryTests.Items
{
    public class ItemTest
    {
        [Test]
        public void AxeStoresValuesCorrectly()
        {
            var axe = new Axe("Axe of Destiny", 5);
            
            Assert.That(axe.IsMagical, Is.False);
            Assert.That(axe.Name, Is.EqualTo("Axe of Destiny"));
            Assert.That(axe.AttackValue, Is.EqualTo(5));
            Assert.That(axe.DefenseValue, Is.EqualTo(0));
        }

        [Test]
        public void ShieldStoresValuesCorrectly()
        {
            var shield = new Shield("Iron Shield", 7);

            Assert.That(shield.IsMagical, Is.False);
            Assert.That(shield.Name, Is.EqualTo("Iron Shield"));
            Assert.That(shield.AttackValue, Is.EqualTo(0));
            Assert.That(shield.DefenseValue, Is.EqualTo(7));
        }

        [Test]
        public void StaffStoresAttackAndDefense()
        {
            var staff = new Staff("Bastón de la Luz", 40, 15);

            Assert.That(staff.IsMagical, Is.True);
            Assert.That(staff.AttackValue, Is.EqualTo(40));
            Assert.That(staff.DefenseValue, Is.EqualTo(15));
        }
    }
}
