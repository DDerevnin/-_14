using NUnit.Framework;

namespace Homework12.UnitTests
{
    [TestFixture]
    public class ElectronicPeriodicalEditionTests
    {
        private static ElectronicPeriodicalEdition edition;

        [SetUp]
        public void Setup()
        {
            edition = new ElectronicPeriodicalEdition("Газета ру", 2020, EditionType.Newspaper);
            edition.Hyperlink = "www.gazeta.ru";
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(edition.Name, Is.EqualTo("Газета ру"));
            Assert.That(edition.Year, Is.EqualTo(2020));
            Assert.That(edition.Type, Is.EqualTo(EditionType.Newspaper));
        }

        [Test]
        public void GetEditionTypeNameTest()
        {
            Assert.That(edition.GetEditionTypeName(), Is.EqualTo("Газета"));
        }

        [Test]
        public void GetInfoTest()
        {
            string expectedInfo = "Название: Газета ру. ";
            expectedInfo += "Год: 2020. ";
            expectedInfo += "Тип: Газета. ";
            expectedInfo += "Гиперссылка: www.gazeta.ru.";
            Assert.That(edition.GetInfo(), Is.EqualTo(expectedInfo));
        }
    }
}