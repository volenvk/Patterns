using NUnit.Framework;

namespace PatternTests.FactoryMethod
{
    using System;
    using BuildPatterns.FactoryMethod;
    using BuildPatterns.FactoryMethod.Factories;

    public class FactoryMethodTest
    {
        [Test]
        public void TestOpenAndRead()
        {
            var factoryBook = new FactoryBook();
            var book = factoryBook.Create();
            Assert.IsTrue(book.Open());
            Assert.AreEqual("text", book.Read());
            
            var factoryAtlas = new FactoryAtlas();
            var atlas = factoryAtlas.Create();
            Assert.IsTrue(atlas.Open());
            Assert.AreEqual("map", atlas.Read());
            
            var factoryMagazine = new FactoryMagazine();
            var magazine = factoryMagazine.Create();
            Assert.IsTrue(magazine.Open());
            Assert.AreEqual("text and picture", magazine.Read());
        }

        [Test]
        public void TestHumanRead()
        {
            var human  = new Human();

            Assert.Catch<ArgumentNullException>(() => human.Read());
            
            human.TakeSomethingRead(new FactoryBook());
            Assert.AreEqual("text", human.Read());
            human.TakeSomethingRead(new FactoryAtlas());
            Assert.AreEqual("map", human.Read());
            human.TakeSomethingRead(new FactoryMagazine());
            Assert.AreEqual("text and picture", human.Read());
        }

        [Test]
        public void TestBookLibrary()
        {
            var library = new BookLibrary();
            Assert.AreEqual("text", library.Read());
        }
        
        [Test]
        public void TestMagazineLibrary()
        {
            var library = new MagazineLibrary();
            Assert.AreEqual("text and picture", library.Read());
        }
    }
}