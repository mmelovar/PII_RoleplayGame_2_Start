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

            dwarf.EquipAxe(new Axe("Axe of Destiny", 5, 2));
            dwarf.EquipBow(new Bow("Bow of Light", 3, 0));

            Assert.That(dwarf.GetAttackValue(), Is.EqualTo(18));
        }

        [Test]
        public void DwarfDefenseValueIncludesEquippedItems()
        {
            var dwarf = new Dwarf("Alonso", 100, 10, 5);

            dwarf.EquipShield(new Shield("Iron Shield", 2, 7));
            dwarf.EquipHelmet(new Helmet("Bronze Helmet", 0, 4));

            Assert.That(dwarf.GetDefenseValue(), Is.EqualTo(16));
        }

        [Test]
        public void DwarfUnequipsItemAndLowersTotal()
        {
            var dwarf = new Dwarf("Alonso", 100, 10, 5);
            var axe = new Axe("Axe of Destiny", 5, 2);

            dwarf.EquipAxe(axe);
            Assert.That(dwarf.GetAttackValue(), Is.EqualTo(15));

            dwarf.UnequipAxe();
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
    }
}