using NUnit.Framework;
using Library.Items;

namespace LibraryTests.Items
{
    public class ItemTest
    {
        [Test]
        public void AxeStoresValuesCorrectly()
        {
            var axe = new Axe("Axe of Destiny", 5, 2);

            Assert.That(axe.Name, Is.EqualTo("Axe of Destiny"));
            Assert.That(axe.AttackValue, Is.EqualTo(5));
            Assert.That(axe.DefenseValue, Is.EqualTo(2));
        }

        [Test]
        public void ShieldStoresValuesCorrectly()
        {
            var shield = new Shield("Iron Shield", 2, 7);

            Assert.That(shield.Name, Is.EqualTo("Iron Shield"));
            Assert.That(shield.AttackValue, Is.EqualTo(2));
            Assert.That(shield.DefenseValue, Is.EqualTo(7));
        }
    }
}