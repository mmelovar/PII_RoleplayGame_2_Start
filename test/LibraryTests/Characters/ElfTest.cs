using NUnit.Framework;
using Library.Characters;
using Library.Items;

namespace LibraryTests.Characters
{
    public class ElfTest
    {
        [Test]
        public void ElfHasCorrectBaseStats()
        {
            var elf = new Elf("Legolas", 90, 12, 6);

            Assert.That(elf.Name, Is.EqualTo("Legolas"));
            Assert.That(elf.Health, Is.EqualTo(90));
            Assert.That(elf.MaxHealth, Is.EqualTo(90));
            Assert.That(elf.BaseAttack, Is.EqualTo(12));
            Assert.That(elf.BaseDefense, Is.EqualTo(6));
        }

        [Test]
        public void ElfCalculatesAttackAndDefenseFromEquippedItems()
        {
            var elf = new Elf("Legolas", 90, 12, 6);

            elf.EquipSword(new Sword("Elven Sword", 7, 0));
            elf.EquipBow(new Bow("Longbow", 5, 0));
            elf.EquipArmor(new Armor("Leather Armor", 0, 8));
            elf.EquipHelmet(new Helmet("Forest Helmet", 0, 4));

            Assert.That(elf.GetAttackValue(), Is.EqualTo(24));
            Assert.That(elf.GetDefenseValue(), Is.EqualTo(18));
        }

        [Test]
        public void ElfUnequipsSwordAndAttackDrops()
        {
            var elf = new Elf("Legolas", 90, 12, 6);

            elf.EquipSword(new Sword("Elven Sword", 7, 0));
            Assert.That(elf.GetAttackValue(), Is.EqualTo(19));

            elf.UnequipSword();
            Assert.That(elf.GetAttackValue(), Is.EqualTo(12));
        }

        [Test]
        public void ElfReceivesAttack_UsesDefense()
        {
            var elf = new Elf("Legolas", 90, 12, 6);

            elf.ReceiveAttack(20);

            Assert.That(elf.Health, Is.EqualTo(76));
        }

        [Test]
        public void ElfCure_DoesNotExceedMaxHealth()
        {
            var elf = new Elf("Legolas", 90, 12, 6);

            elf.ReceiveAttack(80);
            elf.Cure(30);

            Assert.That(elf.Health, Is.EqualTo(46));
        }

        [Test]
        public void CharacterAttack_ReducesTargetHealth()
        {
            var attacker = new Elf("Legolas", 90, 20, 2);
            var defender = new Dwarf("Alonso", 100, 10, 5);

            attacker.EquipSword(new Sword("Elven Sword", 10, 0));
            attacker.Attack(defender);

            Assert.That(defender.Health, Is.EqualTo(75));
        }
    }
}