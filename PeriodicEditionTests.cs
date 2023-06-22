using System;
using Homework12;
using NUnit.Framework;


[TestFixture]
public class PeriodicEditionTests
{
    private static PeriodicalEdition periodicalEdition;
    
    [SetUp]
    public void Setup()
    {
        periodicalEdition = new PeriodicalEdition("New York Times", 1999, 1);
        periodicalEdition.Type = EditionType.Newspaper;
    }
    [Test]
    public void ConstructorTest()
    {
        Assert.That(periodicalEdition.Name, Is.EqualTo("New York Times"));
        Assert.That(periodicalEdition.Year, Is.EqualTo(1999));
        Assert.That(periodicalEdition.Issue, Is.EqualTo(1));
    }

    [Test]
    public void GetEditionTypeNameTest()
    {
        Assert.That(periodicalEdition.GetEditionTypeName(), Is.EqualTo("Газета"));
    }
    
    [Test]
    public void GetInfoTest()
    {
        string expectedInfo = "Название: New York Times. ";
        expectedInfo += "Год: 1999. ";
        expectedInfo += "Выпуск: 1. ";
        expectedInfo += "Цена: 0. ";
        expectedInfo += "Тип: Газета.";
        Assert.That(periodicalEdition.GetInfo(), Is.EqualTo(expectedInfo));
    }
}