using System;
using NUnit.Framework;

namespace Homework12.UnitTests
{
    [TestFixture]
    public class IComparableTests
    {
        private static PeriodicalEdition edition1;
        private static ElectronicPeriodicalEdition edition2;
        private static PeriodicalEdition edition3;
        private static EditionComparer comparer;
        private static Edition[] editions;
        private static Catalogue catalogue;
        
        [SetUp]
        public void Setup()
        {
            edition1 = new PeriodicalEdition("Газета 1", 2020, 1);
            edition2 = new ElectronicPeriodicalEdition("Каталог", 2020, EditionType.Catalogue);
            edition3 = new PeriodicalEdition("Журнал", 2019, 2) { Type = EditionType.Magazine };
            comparer = new EditionComparer();
            editions = new Edition[] { edition1, edition2, edition3 };
            catalogue = new Catalogue(editions);
        }

        [Test]
        public void CompareToTest()
        {
            Assert.That(edition1.CompareTo(edition2), Is.LessThan(0));
            Assert.That(edition1.CompareTo(edition3), Is.LessThan(0));
        }

        [Test]
        public void ComparerTest()
        {
            Assert.That(comparer.Compare(edition1, edition2), Is.LessThan(0));
            Assert.That(comparer.Compare(edition1, edition3), Is.LessThan(0));
        }

        [Test]
        public void CatalogueCountTest()
        {
            Assert.That(catalogue.Count, Is.EqualTo(3));
        }
        
        [Test]
        public void IEnumerableTest()
        {
            var i = 0;
            foreach(var member in catalogue)
                Assert.That(member, Is.SameAs(editions[i++]));
        }
    }
}